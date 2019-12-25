namespace MarmaraKargo.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class ModelMarmara : DbContext
    {
        public ModelMarmara()
            : base("name=ModelMarmara")
        {
        }

        public virtual DbSet<CITIES> CITIES { get; set; }
        public virtual DbSet<DETAILS> DETAILS { get; set; }
        public virtual DbSet<SENIORS> SENIORS { get; set; }
        public virtual DbSet<SHIPMENTS> SHIPMENTS { get; set; }
        public virtual DbSet<STATUSES> STATUSES { get; set; }
        public virtual DbSet<sysdiagrams> sysdiagrams { get; set; }
        public virtual DbSet<USERS> USERS { get; set; }
        public virtual DbSet<USERTYPES> USERTYPES { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CITIES>()
                .HasMany(e => e.USERS)
                .WithRequired(e => e.CITIES)
                .HasForeignKey(e => e.CityID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<STATUSES>()
                .HasMany(e => e.DETAILS)
                .WithRequired(e => e.STATUSES)
                .HasForeignKey(e => e.StatusID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<STATUSES>()
                .HasMany(e => e.SHIPMENTS)
                .WithRequired(e => e.STATUSES)
                .HasForeignKey(e => e.StatusID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<USERS>()
                .Property(e => e.Lat)
                .HasPrecision(9, 6);

            modelBuilder.Entity<USERS>()
                .Property(e => e.Lon)
                .HasPrecision(9, 6);

            modelBuilder.Entity<USERS>()
                .HasMany(e => e.DETAILS)
                .WithRequired(e => e.USERS)
                .HasForeignKey(e => e.InformantID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<USERS>()
                .HasMany(e => e.SENIORS)
                .WithRequired(e => e.USERS)
                .HasForeignKey(e => e.UserID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<USERS>()
                .HasMany(e => e.SHIPMENTS)
                .WithRequired(e => e.USERS)
                .HasForeignKey(e => e.SenderID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<USERS>()
                .HasMany(e => e.SHIPMENTS1)
                .WithRequired(e => e.USERS1)
                .HasForeignKey(e => e.ReceiverID)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<USERTYPES>()
                .HasMany(e => e.USERS)
                .WithRequired(e => e.USERTYPES)
                .HasForeignKey(e => e.Type)
                .WillCascadeOnDelete(false);
        }
    }
}
