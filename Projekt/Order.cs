namespace Projekt
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Order
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Order()
        {
            Lists = new HashSet<List>();
        }

        public int? ID { get; set; }

        public int? PriceSum { get; set; }

        public int SumPreparingTIme { get; set; }

        [Required]
        [StringLength(50)]
        public string Status { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<List> Lists { get; set; }

        public override string ToString() {
            return ID + " Cijena: " + PriceSum + "Vrijeme pripreme: "+SumPreparingTIme;
        }
    }
}
