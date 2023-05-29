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
        public IEnumerable<ProductCategory> GetProductCategories(int id) {
            return
              from n in db.ProductCategorys
              where n.ID == id
              select n;
              
        }
    }
}
