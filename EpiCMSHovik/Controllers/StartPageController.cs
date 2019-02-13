using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using EpiCMSHovik.Models.Pages;
using EpiCMSHovik.Models.ViewModels;
using EPiServer;
using EPiServer.Core;
using EPiServer.Framework.DataAnnotations;
using EPiServer.Web.Mvc;

namespace EpiCMSHovik.Controllers
{
    public class StartPageController : PageControllerBase<StartPage>
    {
        public ActionResult Index(StartPage currentPage)
        {
            DefaultPageViewModel<StartPage> pageViewModel = new DefaultPageViewModel<StartPage>(currentPage);

            return View(pageViewModel);
        }
    }
}