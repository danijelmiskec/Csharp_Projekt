using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt {
    internal class Products {
        private AppContext db;


        public Products() {
            db = new AppContext();
        }
        public IEnumerable<Product> GetProducts() {
            return
              from n in db.Products
              orderby n.ID
              select n;
        }
        public IEnumerable<Product> GetProducts(int categoryID) {
            return
              from n in db.Products
              where n.CategoryID == categoryID
              orderby n.ID
              select n;
        }
        //Update ili insert producta
        public void UpdateNote(Product product) {
            db.Products.AddOrUpdate(product);
            db.SaveChanges();
            
        }
    }
}
