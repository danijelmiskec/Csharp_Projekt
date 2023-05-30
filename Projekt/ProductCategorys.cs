using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt {
    internal class ProductCategorys {
        private AppContext db;


        public ProductCategorys() {
            db = new AppContext();
        }
        public IEnumerable<ProductCategory> GetProductCategories() {
            return
              from n in db.ProductCategorys
              orderby n.ID
              select n;
              
        }

        /*
        public IEnumerable<ProductCategory> GetProductCategories(int id) {
            return
              from n in db.ProductCategorys
              where n.ID != id
              select n;
        
        }*/


        //pretraga kategorije pomocu id-a
        public ProductCategory GetProductCategory(int id) {
            var category =
              from n in db.ProductCategorys
              where n.ID == id
              select n;

            if (!category.Any()) {
                return null;
            }

            return category.First();
        }
    }
}
