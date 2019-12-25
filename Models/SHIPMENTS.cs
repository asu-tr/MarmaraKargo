namespace MarmaraKargo.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SHIPMENTS
    {
        public int ID { get; set; }

        public long TrackNo { get; set; }

        public int SenderID { get; set; }

        public int ReceiverID { get; set; }

        public int StatusID { get; set; }

        [Required]
        [StringLength(50)]
        public string SenderName { get; set; }

        [Required]
        [StringLength(50)]
        public string ReceiverName { get; set; }

        public double Weight { get; set; }

        public double? Price { get; set; }

        public virtual STATUSES STATUSES { get; set; }

        public virtual USERS USERS { get; set; }

        public virtual USERS USERS1 { get; set; }
    }
}
