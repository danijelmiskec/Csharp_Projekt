namespace Projekt
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class List
    {
        public List() {
        }
        public int? ID { get; set; }

        public int? OrderID { get; set; }

        public int? ProductID { get; set; }

        public int? Amount { get; set; }

        public int? SizeID { get; set; }

        public virtual Product Product { get; set; }

        public virtual Size Size { get; set; }

        public virtual Order Order { get; set; }

        public static implicit operator List<object>(List v) {
            throw new NotImplementedException();
        }
    }
}
