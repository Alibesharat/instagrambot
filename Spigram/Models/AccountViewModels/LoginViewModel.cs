using System.ComponentModel.DataAnnotations;

namespace Spigram.Models.AccountViewModels
{
    public class LoginViewModel
    {
        [Required(ErrorMessage = "ورود {0} الزامی است")]
       
        [Display(Name ="نام کاربری")]
        public string userrname { get; set; }

        [Required(ErrorMessage = "ورود {0} الزامی است")]
        [Display(Name = "رمز عبور")]
        [DataType(DataType.Password)]
        public string Password { get; set; }

        [Display(Name = "مرا به یاد داشته باش")]
        public bool RememberMe { get; set; }
    }
}
