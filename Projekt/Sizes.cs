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
        public IEnumerable<Size> GetSizes(int categoryID) {
            return
              from n in db.Sizes
              where n.CategoryID == categoryID
              orderby n.ID
              select n;
        }
        public Size GetSizeID(string name) {
            return(
              from n in db.Sizes
              where n.Name == name
              orderby n.ID
              select n).First();
        }

        public Size GetSize(int? ID) {
            if (ID != null) {
                return (
                from n in db.Sizes
                where n.ID == ID
                select n).First();
            }
            else { return null; }

        }
    }
}
