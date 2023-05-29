using System;
using System.Collections.Generic;
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
    }
}
