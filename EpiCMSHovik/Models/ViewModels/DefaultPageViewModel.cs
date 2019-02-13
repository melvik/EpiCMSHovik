using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EpiCMSHovik.Models.Pages;
using EpiCMSHovik.Business;
using EPiServer.Core;

namespace EpiCMSHovik.Models.ViewModels
{
    public class DefaultPageViewModel<T> : IPageViewModel<T> where T : SitePageData
    {
        public T CurrentPage { get; set; }

        public IContent Section { get; set; }

        public DefaultPageViewModel(T currentPage)
        {
            CurrentPage = currentPage;
            Section = ContentExtensions.GetSection(currentPage.ContentLink);
        }
    }
}