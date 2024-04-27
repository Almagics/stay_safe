using System.ComponentModel.DataAnnotations;

namespace stay_safe.Models
{
    public class HospitalModel
    {
        [Key]
        public int HospitalId { get; set; }

        [Required]
        public string Name { get; set;}

        [Required]
        public string Address { get; set;}

        [Display(Name ="Number Of Bed")]
        public int BedNumber { get; set;}

        [Required]
        public string UserId { get; set;}

    }
}
