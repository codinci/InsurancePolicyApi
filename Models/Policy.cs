using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace InsurancePolicyApi.Models
{
    public class Policy
    {
        [Key]
        public int PolicyId { get; set; }

        [Column(TypeName = "varchar(100)")]
        public string PolicyName { get; set; } = string.Empty;
        [Column(TypeName = "varchar(255)")]
        public string PolicyDescription { get; set; } = string.Empty;
    }
}
