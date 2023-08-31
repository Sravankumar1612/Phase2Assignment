using Assignment13.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Assignment13.Controllers
{
    public class TeamPageDbController : Controller
    {
        List<TeamPage> teamPages = new List<TeamPage>() { 
            new TeamPage(){TeamId = 1,TeamName="India",NOCW="2"},
            new TeamPage(){TeamId = 2,TeamName="Australia",NOCW="4"},
            new TeamPage(){TeamId = 3,TeamName="WestIndies",NOCW="2"},
            new TeamPage(){TeamId = 4,TeamName="England",NOCW="1"},
        };
        // GET: TeamPageDb
        public ActionResult Index()
        {
            return View(teamPages);
        }
    }
}