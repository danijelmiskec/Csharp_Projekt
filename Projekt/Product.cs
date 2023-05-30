namespace Projekt
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Product
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Product()
        {
            Lists = new HashSet<List>();
        }
        public Product(string name, int price,int preparingTime,int categoryID) {
            this.Name = name;
            this.Price = price;
            this.PreparingTime = preparingTime;
            this.CategoryID = categoryID;
        }

        public int? ID { get; set; }

        public string Name { get; set; }

        public int? Price { get; set; }

        public int? PreparingTime { get; set; }

        public int? CategoryID { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<List> Lists { get; set; }

        public virtual ProductCategory ProductCategory { get; set; }
    }
}
