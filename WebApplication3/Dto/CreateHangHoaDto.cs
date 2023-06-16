using System.ComponentModel.DataAnnotations;

namespace WebApplication3.Dto
{
    public class CreateHangHoaDto
    {
        [Required]
        [MaxLength(100)]
        private string _tenHangHoa;
        public string tenHangHoa
        {
            get => _tenHangHoa;
            set => _tenHangHoa = value?.Trim();
        }

        [Range(0, double.MaxValue)]
        public double donGia { get; set; }
    }
}
