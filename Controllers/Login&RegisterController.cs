using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Recipe__MVCProject.Models;

namespace Recipe__MVCProject.Controllers
{
    public class Login_RegisterController : Controller
    {
        private readonly ModelContext _context;

        public Login_RegisterController(ModelContext context)
        {
            _context = context;
        }

        public IActionResult LogIn()
        {
            return View();
        }


        public IActionResult Register()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> LogIn(User userModel)
        {
            var log = await _context.Users
                                    .SingleOrDefaultAsync(x => x.Username == userModel.Username && x.Password == userModel.Password);

            if (log != null)
            {
                switch (log.Roleid)
                {
                    case 1:  
                        return RedirectToAction("Index", "Admin");

                    case 2:  
                        return RedirectToAction("ContactUs", "Home");

                    case 3:  
                        return RedirectToAction("AboutUs", "Home");  

                    default:
                        
                        return RedirectToAction("Index", "Home");
                }
            }
            else
            {
                
                ModelState.AddModelError(string.Empty, "Invalid login attempt.");
                return View(userModel);
            }
        }


        [HttpPost]
        public IActionResult Register(User user, string Email, string userName, string Password, string roleType)
        {
            if (ModelState.IsValid)
            {
                user.Email = Email;  
                user.Username = userName;
                user.Password = Password;

                
                if (roleType == "Register as Chef")
                {
                    user.Roleid = 3; 
                }
                else if (roleType == "Register as User")
                {
                    user.Roleid = 2; 
                }
                else
                {
                    
                    user.Roleid = 2; 
                }

                _context.Add(user);
                _context.SaveChanges();
            }

            return View();
        }

    }
}
