using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace PaymentAPI.Models
{
    public class PaymentDetails
    {
        [Key]
        public int PaymentDetailId { get; set; }
        [Column (TypeName ="navarchar (100)")]
        public string CardOwnerName { get; set; }
        [Column(TypeName = "navarchar (16)")]

        public string CardNumber { get; set; }
        [Column(TypeName = "navarchar (5)")]

        public string ExpritionDate { get; set; }
        [Column(TypeName = "navarchar (3)")]
        public string SecurityCode { get; set; }


    }
}
