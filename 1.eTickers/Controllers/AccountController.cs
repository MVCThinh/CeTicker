﻿using _1.eTickers.Data;
using _1.eTickers.Data.Static;
using _1.eTickers.Data.ViewModels;
using _1.eTickers.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;



namespace _1.eTickers.Controllers
{
    public class AccountController : Controller
    {
        private readonly UserManager<ApplicationUser> _userManager;
        private readonly SignInManager<ApplicationUser> _signManager;
        private readonly AppDbContext _context;

        public AccountController(UserManager<ApplicationUser> userManager, SignInManager<ApplicationUser> signManager, AppDbContext context)
        {
            _userManager = userManager;
            _signManager = signManager;
            _context = context;
        }
        [Authorize(Roles = UserRoles.Admin)]
        public async Task<IActionResult> Users()
        {
            var users = await _context.Users.ToListAsync();
            return View(users);

        }

        public  IActionResult Login() => View(new LoginVM());

        [HttpPost]
        public async Task<IActionResult> Login(LoginVM loginVM)
        {
            if (!ModelState.IsValid)
            {
                return View(loginVM);
            }

            var user = await _userManager.FindByEmailAsync(loginVM.Email);
            if (user != null)
            {
                var passwordCheck = await _userManager.CheckPasswordAsync(user, loginVM.Password);
                if (passwordCheck)
                {
                    var result = await _signManager.PasswordSignInAsync(user, loginVM.Password, false, false);
                    if (result.Succeeded)
                    {
                        return RedirectToAction("Index", "Movies");
                    }
                }
                TempData["Error"] = "Wrong credentials. Please, try again";
                return View(loginVM);
            }
            TempData["Error"] = "Wrong credentials. Please, try again";
            return View(loginVM);
        }

        public IActionResult Register() => View(new RegisterVM());

        [HttpPost]
        public async Task<IActionResult> Register(RegisterVM registerVM)
        {
            if(!ModelState.IsValid) return View(registerVM);

            var user = await _userManager.FindByEmailAsync(registerVM.Email);
            if (user != null)
            {
                TempData["Error"] = "This email address is already in use";
                return View(registerVM);
            }

            var newUser = new ApplicationUser()
            {
                FullName = registerVM.FullName,
                Email = registerVM.Email,
                UserName = registerVM.Email
            };
            var newUserResponse = await _userManager.CreateAsync(newUser, registerVM.Password);

            if (newUserResponse.Succeeded)
                await _userManager.AddToRoleAsync(newUser, UserRoles.User);

            return View("RegisterCompleted");

        }


        [HttpPost]
        public async Task<IActionResult> Logout()
        {
            await _signManager.SignOutAsync();
            return RedirectToAction("Index", "Movies");
        }

        public IActionResult AccessDenied(string ReturnUrl)
        {
            return View();
        }
    }
}
