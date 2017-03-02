namespace RetailCustomers.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class CustomersModel : DbContext
    {
        public CustomersModel()
            : base("name=customers")
        {
        }

        public virtual DbSet<Table> Tables { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Table>()
                .Property(e => e.FirstName)
                .IsUnicode(false);

            modelBuilder.Entity<Table>()
                .Property(e => e.LastName)
                .IsUnicode(false);

            modelBuilder.Entity<Table>()
                .Property(e => e.Address)
                .IsUnicode(false);

            modelBuilder.Entity<Table>()
                .Property(e => e.City)
                .IsUnicode(false);

            modelBuilder.Entity<Table>()
                .Property(e => e.State)
                .IsUnicode(false);
        }
    }
}
