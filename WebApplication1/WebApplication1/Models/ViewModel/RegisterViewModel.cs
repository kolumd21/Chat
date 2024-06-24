using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;

namespace WebApplication1.Models.ViewModel
{
    public class RegisterViewModel
    {
        [Required(ErrorMessage ="Укажите имя!")]
        [MaxLength(20,ErrorMessage ="Логин должен содержать не более 20 символов!")]
        [MinLength(3, ErrorMessage = "Логин должен содержать более 3 символов!")]
        public string Login { get; set; }


        [EmailAddress(ErrorMessage = "Емаил указан неверно")]
        [Required(ErrorMessage = "Укажите Емаил!")]
        public string Email { get; set; }


        [DataType(DataType.Password)]
        [Required(ErrorMessage ="Укажите пароль!")]
        [MaxLength(16, ErrorMessage = "Пароль должен содержать не более 16 символов!")]
        [MinLength(4, ErrorMessage = "Пароль должен содержать более 4 символов!")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Required(ErrorMessage = "Подтвердите пароль")]
        [Compare("Password",ErrorMessage ="Пароли не совпадают")]
        public string PasswordConfirm { get; set; }
    }
}
