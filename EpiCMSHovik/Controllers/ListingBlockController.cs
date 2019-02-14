using System.Web.Mvc;
using EpiCMSHovik.Models.Blocks;
using EpiCMSHovik.Models.ViewModels;
using EPiServer;
using EPiServer.Core;
using EPiServer.ServiceLocation;
using EPiServer.Web.Mvc;

namespace EpiCMSHovik.Controllers
{
    public class ListingBlockController : BlockController<ListingBlock>
    {
        public override ActionResult Index(ListingBlock currentBlock)
        {
            var contentRepository = ServiceLocator.Current.GetInstance<IContentLoader>();
            var model = new ListingBlockModel();
            model.Heading = currentBlock.Heading;
            if (currentBlock.RootPage != null)
            {
                model.Items = contentRepository.GetChildren<PageData>(currentBlock.RootPage);
            }
            else
            {
                model.Items = null;
            }

            return PartialView(model);
        }
    }
}
