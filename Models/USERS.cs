namespace MarmaraKargo.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class USERS
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public USERS()
        {
            DETAILS = new HashSet<DETAILS>();
            SENIORS = new HashSet<SENIORS>();
            SHIPMENTS = new HashSet<SHIPMENTS>();
            SHIPMENTS1 = new HashSet<SHIPMENTS>();
        }

        public int ID { get; set; }

        public int Type { get; set; }

        [Required]
        [StringLength(20)]
        public string Username { get; set; }

        [Required]
        [StringLength(20)]
        public string Password { get; set; }

        public int CityID { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        public long Telephone { get; set; }

        [Required]
        [StringLength(80)]
        public string Address { get; set; }

        public decimal Lat { get; set; }

        public decimal Lon { get; set; }

        public virtual CITIES CITIES { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<DETAILS> DETAILS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SENIORS> SENIORS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SHIPMENTS> SHIPMENTS { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<SHIPMENTS> SHIPMENTS1 { get; set; }

        public virtual USERTYPES USERTYPES { get; set; }
    }
}
