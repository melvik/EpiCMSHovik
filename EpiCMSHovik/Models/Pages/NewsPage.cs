using System.ComponentModel.DataAnnotations;
using EpiCMSHovik.Models.Blocks;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;

namespace EpiCMSHovik.Models.Pages
{
    [ContentType(DisplayName = "NewsPage", GUID = "30b2dd33-21a3-49a5-a4dc-414faed70f99", Description = "NEWSSS")]
    public class NewsPage : StandardPage
    {
        [Display(
            GroupName = SystemTabNames.Content,
            Order = 315)]
        public virtual ListingBlock MainListing { get; set; }
    }
}