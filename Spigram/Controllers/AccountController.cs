using InstagarmBot.Data;
using InstagarmBot.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Spigram.Extensions;
using Spigram.Models.AccountViewModels;
using System.Linq;
using System.Threading.Tasks;

namespace Spigram.Controllers
{
    [Authorize]
    [Route("[controller]/[action]")]
    public class AccountController : Controller
    {
        private readonly SpigramContext _context;

        public AccountController(SpigramContext context
           )
        {
            _context = context;
        }

        [TempData]
        public string ErrorMessage { get; set; }

        [HttpGet]
        [AllowAnonymous]
        public  IActionResult Login(string returnUrl = null)
        {
            // Clear the existing external cookie to ensure a clean login process
            HttpContext.Response.Cookies.Delete(CookieName.spigram_dfs.ToString());
            ViewData["ReturnUrl"] = returnUrl;
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public  IActionResult Login(LoginViewModel model, string returnUrl = null)
        {
            ViewData["ReturnUrl"] = returnUrl;
            if (ModelState.IsValid)
            {
                // This doesn't count login failures towards account lockout
                // To enable password failures to trigger account lockout, set lockoutOnFailure: true
                var result = _context.users.FirstOrDefault(c => c.userName == model.userrname && c.password == model.Password);
                if (result != null)
                {
                    HttpContext.AddCoookie(result.Id.ToString());
                    return RedirectToLocal(returnUrl);
                }

                else
                {
                    ModelState.AddModelError(string.Empty, "ورود ناموفق");
                    return View(model);
                }
            }

            // If we got this far, something failed, redisplay form
            return View(model);
        }



        [HttpGet]
        [AllowAnonymous]
        public IActionResult Register(string returnUrl = null)
        {
            ViewData["ReturnUrl"] = returnUrl;
            return View();
        }

        [HttpPost]
        [AllowAnonymous]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Register(RegisterViewModel model, string returnUrl = null)
        {
            ViewData["ReturnUrl"] = returnUrl;
            if (ModelState.IsValid)
            {
                var olduser = _context.users.FirstOrDefault(c => c.userName == model.userName);
                if (olduser != null)
                {
                    ModelState.AddModelError("", "این نام کاربری از قبل موجود است");
                    return View(model);

                }
                var user = new user { userName = model.userName, password = model.Password };
                await _context.users.AddAsync(user);
                await _context.SaveChangesAsync();
                return RedirectToLocal(returnUrl);

            }

            // If we got this far, something failed, redisplay form
            return View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public  IActionResult Logout()
        {
            HttpContext.Response.Cookies.Delete(CookieName.spigram_dfs.ToString());
            return RedirectToAction(nameof(HomeController.Index), "Home");
        }

      

        #region Helpers

        private void AddErrors(IdentityResult result)
        {
            foreach (var error in result.Errors)
            {
                ModelState.AddModelError(string.Empty, error.Description);
            }
        }

        private IActionResult RedirectToLocal(string returnUrl)
        {
            if (Url.IsLocalUrl(returnUrl))
            {
                return Redirect(returnUrl);
            }
            else
            {
                return RedirectToAction(nameof(HomeController.Index), "Home");
            }
        }

        #endregion
    }
}
