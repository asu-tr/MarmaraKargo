namespace MarmaraKargo.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SENIORS
    {
        public int ID { get; set; }

        public int UserID { get; set; }

        public int SeniorID { get; set; }

        public virtual USERS USERS { get; set; }
    }
}
