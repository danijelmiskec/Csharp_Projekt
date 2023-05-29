using System;
using System.Collections.Generic;
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
    }
}
