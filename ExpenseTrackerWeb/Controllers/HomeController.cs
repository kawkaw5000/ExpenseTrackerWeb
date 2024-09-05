using ExpenseTrackerWeb.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using ExpenseTrackerWeb.Contracts;
using Microsoft.AspNetCore.Authorization;

namespace ExpenseTrackerWeb.Controllers
{
 
    public class HomeController : BaseController
    {
        [Authorize]
        public IActionResult Dashboard()
        {
            List<User> userList = _userRepo.GetAll();
            return View(userList);
        }

    }
}
