using Microsoft.AspNetCore.Authentication.Cookies;

namespace Debtor.Web;

public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);

        #region Config authentication

        // nakonfiguruju autentizaci pøes cookies - cookie ukládá spojení a pamatuje si pøihlášeného uživatele - session
        // Token v cookies posílám s každým requestem na server - server ovìøí platnost tokenu a podle toho rozhodne, zda je uživatel pøihlášený nebo ne
        // druhý zpùsob - localstorage - ta se ale dá strašnì lehce èíst a mìnit - není bezpeèná
        // cookies nastavit HTTP only - nedá se èíst z JavaScriptu - bezpeènìjší
        // v reálném svìtì mám tøeba 50 serverù - load balancer - potøebuji sdílet session mezi servery

        // Add services to the container.
        builder.Services.AddControllersWithViews();

        
        // konstatnta pro cookie autentizaci - lepší než "Cookies" na prasáka
        builder.Services.AddAuthentication(CookieAuthenticationDefaults.AuthenticationScheme)
            .AddCookie(options => {
                options.LoginPath = "/Users/Login"; // možná zvážit Auth/Login
                                                    //options.LogoutPath = "/Users/Logout"; // extra

                //options.Cookie.Name = "DebtorAuthCookie"; // název cookie
                options.Cookie.HttpOnly = true; // cookie nejde èíst z JavaScriptu
                options.Cookie.SameSite = SameSiteMode.Lax; // omezení posílání cookie na stejné stránky - proti CSRF útokùm
            });
        #endregion

        var app = builder.Build();

        // Configure the HTTP request pipeline.
        if (!app.Environment.IsDevelopment())
        {
            app.UseExceptionHandler("/Home/Error");
            // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
            app.UseHsts();
        }

        app.UseHttpsRedirection();
        app.UseStaticFiles();

        app.UseRouting();

        #region zapnutí Autentizace
        app.UseAuthentication(); // musím zapnout pøed autorizací (autentizace -> autorizace)
        app.UseAuthorization(); // autorizace - co mùžu? X autentizace - kdo jsem?

        app.MapControllerRoute(
            name: "default",
            pattern: "{controller=Home}/{action=Index}/{id?}");

        app.Run();
        #endregion
    }
}
