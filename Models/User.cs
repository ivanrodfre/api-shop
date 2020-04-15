using System.ComponentModel.DataAnnotations;

namespace Shop.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        [MaxLength(20, ErrorMessage = "Este campo deve conter entre 3 e 60 carcteres")]
        [MinLength(3, ErrorMessage = "Este campo deve conter entre 3 e 60 carcteres")]
        public string Username { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        [MaxLength(20, ErrorMessage = "Este campo deve conter entre 3 e 60 carcteres")]
        [MinLength(3, ErrorMessage = "Este campo deve conter entre 3 e 60 carcteres")]
        public string Password { get; set; }

        public string Role { get; set; }
    }
}