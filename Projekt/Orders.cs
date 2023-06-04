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
        public delegate void OrderDelegat(object sender);

        public Orders() {
            db = new AppContext();
            UPrimpremi = new List<Order>();
            ZaPredaju = new List<Order>();
        }
        public Order GetOrder(Order order) {
            return(
            from n in db.Orders
            where n.PriceSum == order.PriceSum && n.SumPreparingTIme == order.SumPreparingTIme 
            select n).First();
        }
        public void NewOrder(Order order) {
            Task work = new Task(() => {
                Thread.Sleep(2000);
                UPrimpremi.Add(order);
                PripremaSe?.Invoke(this);
                Thread.Sleep(order.SumPreparingTIme);
                gotovaPriprema(order);
                PredajeSe?.Invoke(this);
            });
            work.Start();
        }

        public void gotovaPriprema(Order order) {
            ZaPredaju.Add(order);
            UPrimpremi.Remove(order);
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

        public void InsertOrder(Order order) {
            db.Orders.AddOrUpdate(order);
            db.SaveChanges();
        }


        public event OrderDelegat PripremaSe;
        public event OrderDelegat PredajeSe;

        public List<Order> UPrimpremi { get; set; }
        public List<Order> ZaPredaju { get; set; }
    }
}
