using System.ComponentModel.DataAnnotations;

namespace Spigram.Models.AccountViewModels
{
    public class RegisterViewModel
    {
        
        [Display(Name = "نام کاربری")]

        public string userName { get; set; }

        [Required(ErrorMessage = "ورود {0} الزامی است")]
        [DataType(DataType.Password)]
        [Display(Name = "رمز عبور")]
        public string Password { get; set; }

        [DataType(DataType.Password)]
        [Display(Name = "تکرار رمز عبور ")]
        [Compare("Password", ErrorMessage = "رمز عبور و تکرار آن برابر نیستند")]
        public string ConfirmPassword { get; set; }
    }
}
