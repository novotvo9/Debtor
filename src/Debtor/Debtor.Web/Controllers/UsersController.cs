using Debtor.DataAcess.Contexts;
using Debtor.DataAcess.Entities;
using Debtor.Web.Models.Users;
using Microsoft.AspNetCore.Authentication;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace Debtor.Web.Controllers;

public class UsersController : Controller
{
    public MyDbContext MyDbContext { get; set; } = new();

    [HttpGet]
    public IActionResult Login()
    {
        UsersLoginViewModel model = new();
        return View(model);
    }

    [HttpPost]
    public async Task<IActionResult> Login(UsersLoginViewModel model)
    {
        User? user = MyDbContext.Users.FirstOrDefault(u => u.Email == model.Email && u.Password == HashPassword(model.Password));

        if (user == null)
        {
            return View(model); // Error?
        }

        // Claims - informace o uživateli, které chci uložit do cookie
            // id, email, role?
        List<Claim> claims = [];

        Claim idClaim = new("id", user.Id.ToString());
        Claim emailClaim = new("email", user.Email);

        claims.Add(idClaim);
        claims.Add(emailClaim);

        // teď přiřadit claimy ke cookies schématu - vytvořit identitu, může jich mít víc (github, google, microsoft...)
        ClaimsIdentity identity = new(claims, CookieAuthenticationDefaults.AuthenticationScheme);
        // claims principal - může mít víc identit
        // claimy -> claimsIdentity -> claimsPrincipal
        ClaimsPrincipal principal = new(identity);

        // v HttpContext informace o requestu a response
        // Signin - schéma a principal
        // async - musí přijít postupně - ne že by přišlo třeba jen GET /inde při pomalém internetu
        //i response nazpátek - json, html, redirect... - asynchronní operace
        // seriově paralelně -> concurrently

        await HttpContext.SignInAsync(CookieAuthenticationDefaults.AuthenticationScheme, principal);

        if (user.Email == "admin@hostmaster.com")
        {
            return RedirectToAction("Index", "Home");
        }

        return RedirectToAction("Index", "Dashboard");
    }

    private static string HashPassword(string password) => password;

    [HttpGet]
    public async Task<IActionResult> Logout()
    {
        await HttpContext.SignOutAsync(CookieAuthenticationDefaults.AuthenticationScheme);
        return RedirectToAction("Index", "Home");
    }

    [HttpGet]
    public IActionResult Register()
    {
        UsersRegisterViewModel model = new();
        return View(model);
    }

    [HttpPost]
    public IActionResult Register(UsersRegisterViewModel model)
    {
        if (ModelState.IsValid == false)
        {
            return View(model);
        }

        User newUser = new();
        newUser.Email = model.Email;
        newUser.Password = HashPassword(model.Password);

        MyDbContext.Users.Add(newUser);
        MyDbContext.SaveChanges();

        return RedirectToAction("Login");
    }

}
