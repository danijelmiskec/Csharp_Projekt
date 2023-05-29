using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt {
    internal class Admins {
        private AppContext db;


        public Admins() {
            db = new AppContext();
        }
        public IEnumerable<Admin> GetAdmins() {
            return
              from n in db.Admins
              orderby n.Id
              select n;
        }
    }
}
