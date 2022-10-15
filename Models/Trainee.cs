using System.ComponentModel.DataAnnotations;

namespace TE_CODEFIRST.Models
{
    public class Trainee
    {
        [Key]
        public int TraineeID { get; set; }

        [Required(ErrorMessage = "Enter Name")]
        [RegularExpression(@"^([A-Za-z]+)$")]
        public string TraineeName { get; set; }

        [Range(21, 58, ErrorMessage = "Enter age between 21 to 58")]
        public int TraineeAge { get; set; }

        public DateTime TraineeDOJ { get; set; }
        public DateTime TraineeDOB { get; set; }

        [DataType(DataType.PhoneNumber)]
        public string TraineeMobile { get; set; }

        [DataType(DataType.EmailAddress)]
        public string TraineeEmail { get; set; }

        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Enter the Password")]
        public string TraineePassword { get; set; }

        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Enter the Confirm Password")]
        [Compare("TraineePassword", ErrorMessage = "Password does not match")]
        public string TraineeConfirmPassword { get; set; }

    }
}
