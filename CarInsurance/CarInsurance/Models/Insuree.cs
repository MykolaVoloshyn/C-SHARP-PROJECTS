using System.ComponentModel.DataAnnotations;

namespace CarInsurance.Models
{
    public class Insuree
    {
        public Guid Id { get; set; }

        [Required]
        [Display(Name = "First Name"), MaxLength(50)]
        public string FirstName { get; set; }

        [Required]
        [Display(Name = "Last Name"), MaxLength(50)]
        public string LastName { get; set; }

        [Display(Name = "Email"), MaxLength(100)]
        [EmailAddress(ErrorMessage = "Incorrect email address format.")]
        public string EmailAddress { get; set; }

        [Required]
        [Display(Name = "Date of Birth")]
        [CustomValidation(typeof(Insuree), nameof(DateOfBirthValidation))]
        public DateOnly DateOfBirth { get; set; }

        [Required]
        [Display(Name = "Make of a Car"), MaxLength(50)]
        public string CarMake { get; set; }

        [Required]
        [Display(Name = "Car Model"), MaxLength(100)]
        public string CarModel { get; set; }

        [Required]
        [Display(Name = "Car Year")]
        [Range(1950, 2025, ErrorMessage = "Car year have to be between 1950 and 2025.")]
        public int CarYear { get; set; }

        [Required]
        [Display(Name = "Have DUI")]
        public bool DUI { get; set; }

        [Required]
        [Display(Name = "Speeding Tickets")]
        [Range(0, 20, ErrorMessage = "Speeding tickets number must be between 0 and 20")]
        public int SpeedingTickets { get; set; }

        [Required]
        [Display(Name = "Type of Coverage")]
        public string CoverageType { get; set; }

        public decimal Quote { get; set; }


        public static ValidationResult DateOfBirthValidation(DateOnly dob, ValidationContext context)
        {
            DateOnly today = DateOnly.FromDateTime(DateTime.Today);

            if (dob <= today.AddYears(-16)) return ValidationResult.Success;

            return new ValidationResult("Insuree must be 16 years old or older");
        }

    }
}
