using Microsoft.AspNetCore.Mvc;
using SpaDay.Models;

namespace SpaDay.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public IActionResult Add()
        {
            
            return View();
        }
        [HttpPost]
        [Route("/Index")]
        public IActionResult SubmitAddUserForm(User newUser, string verify)
        {
            //ViewBag.newUser = newUser;
            if(newUser.Password==verify)
            {
                //ViewBag.name = ViewBag.newUser.UserName;
                ViewBag.user = newUser;
                return View("Index");
            }
            else
            {
                ViewBag.error = "Password Not Matching";
                ViewBag.userName = newUser.UserName;
                ViewBag.userEmail = newUser.Email;
                // newUser.Password = verify;
                return View("Add");
            }

            
        }

    }
}
