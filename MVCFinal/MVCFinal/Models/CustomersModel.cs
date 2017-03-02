namespace MVCFinal.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class CustomersModel : DbContext
    {
        public CustomersModel()
            : base("name=CustomersModel")
        {
        }

        public virtual DbSet<CheckingAccount> Tables { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<CheckingAccount>()
                .Property(e => e.FirstName)
                .IsUnicode(false);

            modelBuilder.Entity<CheckingAccount>()
                .Property(e => e.LastName)
                .IsUnicode(false);
        }
    }
}
