using System.ComponentModel.DataAnnotations;

namespace TreatApplication.ViewModels
{
    public class ContactViewModel
    {
        [Required]
        [MinLength(5, ErrorMessage = "Must be 5 Characters")]
        public string Name { get; set; }
        [Required]
        [EmailAddress]
        public string Email { get; set; }
        [Required]
        public string Subject { get; set; }
        [Required]
        [MaxLength(250,ErrorMessage ="Too Long")]
        public string Message { get; set; }

    }
}
