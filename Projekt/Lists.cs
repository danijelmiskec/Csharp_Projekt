using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

        //Update ili insert producta
        public void InsertLists(int orderID,int productID, int amount, int sizeID) {
            var t = new List {
                OrderID = orderID,
                ProductID = productID,
                Amount = amount,
                SizeID = sizeID
            };
            db.Lists.AddOrUpdate(t);
            db.SaveChanges();

        }
    }
}
