using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EpiCMSHovik.Models.Pages;
using EPiServer.Globalization;
using Lucene.Net.Search.Spans;

namespace EpiCMSHovik.Models.ViewModels
{
    public class SearchPageViewModel : IPageViewModel<SearchPage>
    {
        public SearchPage CurrentPage { get; }
        public string SearchText { get; set; }
        //public List<IndexResponseItem> SearchResult { get; set; }

        public SearchPageViewModel(SearchPage currentPage)
        {
            CurrentPage = currentPage;
        }

        public void Search(string q)
        {
            var cultureSet = ContentLanguage.PreferredCulture.Name;
            //SearchResult = new List<IndexResponseItem>();
            //var fieldQueryResult = SearchHandler.
        }
    }
}