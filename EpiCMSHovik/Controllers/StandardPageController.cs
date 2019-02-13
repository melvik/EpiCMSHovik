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
    public class StandardPageController : PageControllerBase<StandardPage>
    {
        public ActionResult Index(StandardPage currentPage)
        {
            /* Implementation of action. You can create your own view model class that you pass to the view or
             * you can pass the page type for simpler templates */
            DefaultPageViewModel<StandardPage> pageViewModel = new DefaultPageViewModel<StandardPage>(currentPage);

            return View(pageViewModel);
        }
    }
}