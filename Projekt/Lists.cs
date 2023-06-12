using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projekt {
    internal class Lists {
        private AppContext db;


        public Lists() {
            db = new AppContext();
        }
        public IEnumerable<List> GetLists() {
            return
              from n in db.Lists
              orderby n.ID
              select n;
        }

        //Update ili insert Lists
        public void InsertLists(TempList podaci, Order order) {
            foreach (var n in podaci.DataList) {
                List list = new List();
                list.ProductID = n.ProductID;
                list.OrderID = order.ID;
                list.SizeID = n.SizeID;
                list.Amount = n.Amount;
                db.Lists.Add(list);
                db.SaveChanges();
            }
        }
    }
}
