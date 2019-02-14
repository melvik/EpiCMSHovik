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
    public class FaqPageController : PageControllerBase<FaqPage>
    {
        public ActionResult Index(FaqPage currentPage)
        {
            var contentRepository = EPiServer.ServiceLocation.ServiceLocator.Current.GetInstance<IContentLoader>();
            currentPage.FaqItems = contentRepository.GetChildren<FaqItem>(currentPage.ContentLink).ToList();
            DefaultPageViewModel<FaqPage> model = new DefaultPageViewModel<FaqPage>(currentPage);

            return View(model);
        }

        public ActionResult Submit(FaqPage currentPage, string question)
        {
            var contentRepository = EPiServer.ServiceLocation.ServiceLocator.Current.GetInstance<IContentRepository>();

            FaqItem fi = contentRepository.GetDefault<FaqItem>(currentPage.ContentLink);

            fi.Name = string.Format("Question: {0}", question);
            fi.Question = question;
            contentRepository.Save(fi, EPiServer.DataAccess.SaveAction.Save, EPiServer.Security.AccessLevel.Read);

            DefaultPageViewModel<FaqPage> model = new DefaultPageViewModel<FaqPage>(currentPage);

            return View("Index", model);

        }
    }
}