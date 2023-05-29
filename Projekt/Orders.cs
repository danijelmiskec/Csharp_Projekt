using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt {
    internal class Orders {
        private AppContext db;


        public Orders() {
            db = new AppContext();
        }
        public IEnumerable<Order> GetAdmins() {
            return
              from n in db.Orders
              orderby n.ID
              select n;
        }
    }
}
