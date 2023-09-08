using System.ComponentModel.DataAnnotations;

namespace HelloRaptors.Models
{
    public class Player
    {
        [Required]
        [StringLength(25)]
        [Display (Name = "Basketball Player Name")]
        public string? PlayerName { get; set; }

        [Required]
        [StringLength(50, MinimumLength=3)]
        [Range (0, 100)]
        public string? Position { get; set; }

        [Compare ("EmailAddressRepeated")]
        [EmailAddress]
        public string? EmailAddress { get; set; }
        [EmailAddress]
        public string? EmailAddressRepeated { get; set; }

        [CreditCard] 
        public int CreditCardNumber { get; set; }
    }
}
