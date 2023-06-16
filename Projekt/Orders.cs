using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Projekt {
    internal class Orders {
        private AppContext db;
        Products products = new Products();
        Lists lists = new Lists();
        public delegate void OrderDelegat(object sender);

        public Orders() {
            db = new AppContext();
            UPrimpremi = new List<Order>();
            ZaPredaju = new List<Order>();
        }
        public void NewOrder(TempList tempList) {
            int TotalPreparingTime = 0;
            int? TotalPrice = 0;
            Order order = new Order();
            foreach (var n in tempList.DataList) {
                Product product = new Product();
                product = products.GetProduct(n.ProductID);
                TotalPreparingTime += n.Amount * product.PreparingTime;
                TotalPrice += product.Price * n.Amount;
            }
            order.PriceSum = TotalPrice;
            order.SumPreparingTIme = TotalPreparingTime;
            order.Status = "U PRIPREMI";
            order = InsertOrder(order);
            lists.InsertLists(tempList, order);
            tempList.DataList.Clear();
            Task work = new Task(() => {
                UPrimpremi.Add(order);
                PripremaSe?.Invoke(this);
                Thread.Sleep((order.SumPreparingTIme*1000)/4); // umanjen preparing time  zbog lakseg testiranja
                gotovaPriprema(order);
                PredajeSe?.Invoke(this);
            });
            work.Start();
        }

        public void gotovaPriprema(Order order) {
            ZaPredaju.Add(order);
            UPrimpremi.Remove(order);
            UpdateOrder(order);
        }

        public IEnumerable<Order> DohvatiUPripremi() {
            return (
                from p in UPrimpremi
                select p);
        }

        public IEnumerable<Order> DohvatiZaPredaju() {
            return (
                from p in ZaPredaju
                select p);
        }

        public Order InsertOrder(Order order) {
            db.Orders.Add(order);
            db.SaveChanges();
            return order;
        }
        public void UpdateOrder(Order order) {
            order.Status = "U PREDAJI";
            db.Orders.AddOrUpdate(order);
            db.SaveChanges();
        }


        public event OrderDelegat PripremaSe;
        public event OrderDelegat PredajeSe;

        public List<Order> UPrimpremi { get; set; }
        public List<Order> ZaPredaju { get; set; }
    }
}
