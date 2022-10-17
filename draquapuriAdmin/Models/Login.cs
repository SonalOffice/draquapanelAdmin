using System.ComponentModel.DataAnnotations;

namespace draquapuriAdmin.Models
{
    public class Login
    {
        [Key]
        public int Id { get; set; }
        [Required (ErrorMessage ="Please enter Phone")]
        public string? Phone { get; set; }
        [Required(ErrorMessage = "Please enter Password")]
        public string? Password { get; set; }
    }
}
