using System;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Microsoft.Owin.Security;
using ReffAppT.Models;

namespace ReffAppT.Controllers
{
    [Authorize]
    public class ManageController : Controller
    {
        private ApplicationUserManager _userManager;
        private ApplicationDbContext db = new ApplicationDbContext();

        public ActionResult Index()
        {
    // var matches = from refe in db.Matches
    //.Include("Referees").Where(Ref => Ref.MatchId == Matches. )
    // select refe;

            return View();
        }

    }
}