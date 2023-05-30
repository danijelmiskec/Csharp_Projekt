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
        public Admin GetAdmin(string username, string password) {
            try {
                return (
                  from n in db.Admins
                  where n.Username == username && n.Password == password
                  select n).First();
            }
            catch { return null; }
        }
    }
}
