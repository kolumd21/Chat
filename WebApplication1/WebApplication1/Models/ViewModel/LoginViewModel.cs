using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models.ViewModel
{
    public class LoginViewModel
    {
        [EmailAddress(ErrorMessage = "Емаил указан неверно")]
        [Required(ErrorMessage = "Укажите Емаил!")]
        public string Email { get; set; }


        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Укажите пароль!")]

        public string Password { get; set; }
    }
}
