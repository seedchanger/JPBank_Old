﻿using JPBank.Data;
using JPBank.Models.DbModels;
using JPBank.Models.Entities;
using Microsoft.AspNetCore.Mvc;

namespace JPBank.Controllers
{
    public class WelcomeController : Controller
    {
        private readonly ApplicationDbContext context;

        public WelcomeController(ApplicationDbContext dbContext)
        {
            this.context = dbContext;
        }

        #region Routing

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }

        public IActionResult Login()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Signup()
        {
            return View();
        }

        #endregion

        #region Actions

        /// <summary>
        /// Create New User (Signup)
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> Signup(SignupEntity signUpEntity)
        {
            if (ModelState.IsValid)
            {
                var user = new UserDbEntity
                {
                    Name = signUpEntity.Name,
                    Email = signUpEntity.Email,
                    Password = signUpEntity.Password,
                    UserType = (int)Constants.UserType.User,
                    IsActive = true,
                    CreatedOn = DateTime.Now
                };
                await context.Tbl_Users.AddAsync(user);
                await context.SaveChangesAsync();
                TempData["UserCreated"] = "You have successfully created an account. Please login with your credentials";
                return RedirectToAction("Login", "Welcome");
            }
            else
            {
                return View(signUpEntity);
            }
        }
        #endregion
    }
}
