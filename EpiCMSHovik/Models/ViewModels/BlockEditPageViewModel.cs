using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EpiCMSHovik.Models.Pages;
using EPiServer.Core;

namespace EpiCMSHovik.Models.ViewModels
{
    public class BlockEditPageViewModel : IPageViewModel<SitePageData>
    {
        public SitePageData CurrentPage { get; }
        public PreviewBlock previewBlock { get; set; }

        public BlockEditPageViewModel(PageData page, IContent content)
        {
            previewBlock = new PreviewBlock(page, content);
            CurrentPage = page as SitePageData;
        }
    }
}