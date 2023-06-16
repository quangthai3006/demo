using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace WebApplication3.Entities
{
    public class HangHoa
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int maHangHoa { get; set; }

        [Required]
        [MaxLength(100)]
        public string tenHangHoa { get; set; }

        [Range(0, double.MaxValue)]
        public double donGia { get; set; }
    }
}
