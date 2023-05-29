using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt {
    internal class Sizes {
        private AppContext db;


        public Sizes() {
            db = new AppContext();
        }
        public IEnumerable<Size> GetSizes() {
            return
              from n in db.Sizes
              orderby n.ID
              select n;
        }
    }
}
