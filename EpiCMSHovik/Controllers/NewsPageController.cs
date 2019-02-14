using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using EpiCMSHovik.Models.Pages;
using EpiCMSHovik.Models.ViewModels;
using EPiServer;
using EPiServer.Core;
using EPiServer.Framework.DataAnnotations;
using EPiServer.Web.Mvc;
using EpiCMSHovik.Models.Blocks;

namespace EpiCMSHovik.Controllers
{
    public class NewsPageController : PageControllerBase<NewsPage>
    {
        [ContentOutputCache]
        public ActionResult Index(NewsPage currentPage)
        {
            /* Implementation of action. You can create your own view model class that you pass to the view or
             * you can pass the page type for simpler templates */

            DefaultPageViewModel<NewsPage> model = new DefaultPageViewModel<NewsPage>(currentPage);
            return View(model);
        }
    }
}