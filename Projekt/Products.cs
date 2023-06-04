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

        public Product GetProduct(string name) {
            return(
              from n in db.Products
              where n.Name == name
              select n).First();
        }

        public Product GetProduct(int? ID) {
            return (
              from n in db.Products
              where n.ID == ID
              select n).First();
        }


        //Update ili insert producta
        public void UpdateProduct(Product product) {
            db.Products.AddOrUpdate(product);
            db.SaveChanges();
            
        }
    }
}
