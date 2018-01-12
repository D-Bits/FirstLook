using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AspAssignments.Models;

namespace AspAssignments.Controllers
{
    public class MailingController : Controller
    {
        // GET: Mailing
        public ActionResult Index()
        {
            Mailing m1 = new Mailing();
            m1.FirstName = "James";
            m1.LastName = "Lahey";
            m1.Email = "jlahey@sunnyvale.com";

            Mailing m2 = new Mailing();
            m2.FirstName = "Randy";
            m2.LastName = "Bobandy";
            m2.Email = "ilovecheeseburgers@sunnyvale.com";

            Mailing m3 = new Mailing();
            m3.FirstName = "George";
            m3.LastName = "Green";
            m3.Email = "dumbcop@dartmouthpd.ca";

            List<Mailing> mailings = new List<Mailing>();
            mailings.Add(m1);
            mailings.Add(m2);
            mailings.Add(m3);

            return View(mailings);
        }
    }
}