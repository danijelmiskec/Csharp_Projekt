using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt {
    public class Temp {
        Products products = new Products();
        Product product = new Product();
        Size Size = new Size();
        Sizes Sizes = new Sizes();
        public Temp(int? productID,int amount, int? sizeID) {
            ProductID = productID;
            Amount = amount;
            SizeID = sizeID;
        }

        public override string ToString() {
           product = products.GetProduct(ProductID);
            Size = Sizes.GetSize(SizeID);
            if(Size != null) {
                return product.Name + " (" + Size.ToString() + ")" + "  " + Amount + " kom";
            }
            else {
                return product.Name + " " + Amount + " kom" ;
            }
           

        }


        public int? ProductID {get; set;}
        public int Amount { get; set;}
        public int? SizeID { get; set;}
    }
}
