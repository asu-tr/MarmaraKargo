namespace MarmaraKargo.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class DETAILS
    {
        public int ID { get; set; }

        public long TrackNo { get; set; }

        public DateTime DateTime { get; set; }

        public int InformantID { get; set; }

        public int StatusID { get; set; }

        public int? ReceiverID { get; set; }

        [StringLength(50)]
        public string DeliveryInfo { get; set; }

        public virtual STATUSES STATUSES { get; set; }

        public virtual USERS USERS { get; set; }
    }
}
