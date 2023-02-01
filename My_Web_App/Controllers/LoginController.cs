using Microsoft.AspNetCore.Mvc;
using My_Web_App.Models;

namespace My_Web_App.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult ProcessLogin(UserModel userModel)
        {
            if (userModel.UserName == "ChetanPagar" && userModel.Password == "Ncs123")
            {
                return View("LoginSuccess", userModel);
            }
            else 
            {
                return View("LoginFailure", userModel);

            }
           
        
        }
    }
}
