namespace MVCFinal.Models
{
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;

    [Table("CheckingAccount")]
    public partial class CheckingAccount
    {
        
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Id { get; set; }

        [StringLength(50)]
        public string FirstName { get; set; }

        [StringLength(50)]
        public string LastName { get; set; }

        public int? AccountNumber { get; set; }

        public int? Balance { get; set; }
    }
}
