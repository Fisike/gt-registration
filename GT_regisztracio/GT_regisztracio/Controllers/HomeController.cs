using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using GT_regisztracio.Models;
using Microsoft.AspNetCore.Identity;
using GT_regisztracio.Data;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace GT_regisztracio.Controllers
{
    public class HomeController : Controller
    {
        UserManager<IdentityUser> userManager;
        RoleManager<IdentityRole> roleManager;
        ApplicationDbContext context;

        public HomeController(UserManager<IdentityUser> userManager,
            RoleManager<IdentityRole> roleManager,
            ApplicationDbContext context)
        {
            this.userManager = userManager;
            this.roleManager = roleManager;
            this.context = context;
        }

        public async Task<IActionResult> Init()
        {
            var first = userManager.Users.First();

            IdentityRole adminRole = new IdentityRole()
            {
                Name = "admin"
            };

            if (await roleManager.FindByNameAsync("admin") == null)
            {
                await roleManager.CreateAsync(adminRole);
                await userManager.AddToRoleAsync(first, "admin");
            }

            return RedirectToAction(nameof(Index));
        }

        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public IActionResult Jelentkezes()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Jelentkezes(Szervezo new_szervezo)
        {
            new_szervezo.UID = Guid.NewGuid().ToString();
            this.context.Szervezok.Add(new_szervezo);
            this.context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }

        [Authorize(Roles = "admin")]
        public IActionResult Jelentkezok()
        {
            return View(this.context.Szervezok.AsEnumerable());
        }

        public IActionResult DeleteJelentkezo(string uid)
        {
            var jelentkezoToDel = this.context.Szervezok.FirstOrDefault(s => s.UID == uid);
            this.context.Remove(jelentkezoToDel);
            this.context.SaveChanges();
            return RedirectToAction(nameof(Jelentkezok));
        }

        [Authorize(Roles = "admin")]
        public IActionResult Admin()
        {
            var users = userManager.Users;
            return View(users);
        }

        public async Task<IActionResult> MakeAdmin(string uid)
        {
            var admin = context.Users.First(a => a.Id == uid);
            
            await userManager.AddToRoleAsync(admin, "admin");

            return RedirectToAction(nameof(Admin));
        }

        public IActionResult DeleteUser(string uid)
        {
            var userToDelete = this.context.Users.FirstOrDefault(u => u.Id == uid);
            this.context.Remove(userToDelete);
            this.context.SaveChanges();
            return RedirectToAction(nameof(Admin));
        }
        
        [Authorize(Roles = "admin")]
        public IActionResult Pontozas()
        {
            ViewData["allSzervezo"] = context.Szervezok.ToList();
            return View();
        }

        public IActionResult AddPont(string szervezo, int tapasztalat, int szervezokepesseg, int szemelyiseg)
        {
            var obj = this.context.Szervezok.FirstOrDefault(o => o.UID == szervezo);
            obj.Pontok.Add(new Pont()
            {
                PontozoNev = this.User.Identity.Name,
                UID = Guid.NewGuid().ToString(),
                Tapasztalat = tapasztalat,
                SzervezoKepesseg = szervezokepesseg,
                Szemelyiseg = szemelyiseg
            });
            this.context.SaveChanges();
            return RedirectToAction(nameof(Pontozas));
        }

        [Authorize(Roles = "admin")]
        public IActionResult Eredmeny()
        {
            return View();
        }

        public IActionResult CsK()
        {
            List<Szervezo> cskSzervezok = new List<Szervezo>();

            foreach (var item in context.Szervezok)
            {
                if (item.Pozicio == "csapatkapitany")
                {
                    cskSzervezok.Add(item);
                }
            }

            List<EredmenyVM> eredmenyek = new List<EredmenyVM>();
            foreach (var csk in cskSzervezok)
            {
                EredmenyVM ujEredmeny = new EredmenyVM();
                int osszPont = 0;
                foreach (var pont in csk.Pontok)
                {
                    osszPont += pont.Szemelyiseg + pont.SzervezoKepesseg + pont.Tapasztalat;
                }

                ujEredmeny.Nev = csk.Vezeteknev + " " + csk.Keresztnev;
                ujEredmeny.Neptun = csk.Neptun;
                ujEredmeny.Osszpont = osszPont;

                eredmenyek.Add(ujEredmeny);
            }
            
            return View(eredmenyek.OrderByDescending(e => e.Osszpont));
        }

        public IActionResult Moka()
        {
            List<Szervezo> mokaSzervezo = new List<Szervezo>();

            foreach (var item in context.Szervezok)
            {
                if (item.Pozicio == "mokaroka")
                {
                    mokaSzervezo.Add(item);
                }
            }

            List<EredmenyVM> eredmenyek = new List<EredmenyVM>();
            foreach (var moka in mokaSzervezo)
            {
                EredmenyVM ujEredmeny = new EredmenyVM();
                int osszPont = 0;
                foreach (var pont in moka.Pontok)
                {
                    osszPont += pont.Szemelyiseg + pont.SzervezoKepesseg + pont.Tapasztalat;
                }

                ujEredmeny.Nev = moka.Vezeteknev + " " + moka.Keresztnev;
                ujEredmeny.Neptun = moka.Neptun;
                ujEredmeny.Osszpont = osszPont;

                eredmenyek.Add(ujEredmeny);
            }

            return View(eredmenyek.OrderByDescending(e => e.Osszpont));
        }

        public IActionResult Programos()
        {
            List<Szervezo> programosok = new List<Szervezo>();

            foreach (var item in context.Szervezok)
            {
                if (item.Pozicio == "programos")
                {
                    programosok.Add(item);
                }
            }

            List<EredmenyVM> eredmenyek = new List<EredmenyVM>();
            foreach (var prog in programosok)
            {
                EredmenyVM ujEredmeny = new EredmenyVM();
                int osszPont = 0;
                foreach (var pont in prog.Pontok)
                {
                    osszPont += pont.Szemelyiseg + pont.SzervezoKepesseg + pont.Tapasztalat;
                }

                ujEredmeny.Nev = prog.Vezeteknev + " " + prog.Keresztnev;
                ujEredmeny.Neptun = prog.Neptun;
                ujEredmeny.Osszpont = osszPont;

                eredmenyek.Add(ujEredmeny);
            }

            return View(eredmenyek.OrderByDescending(e => e.Osszpont));
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
