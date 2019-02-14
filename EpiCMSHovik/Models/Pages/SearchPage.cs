using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;

namespace EpiCMSHovik.Models.Pages
{
    [ContentType(DisplayName = "SearchPage", GUID = "ce08a26e-d72f-4281-9ae5-4cf9d7ca9379", Description = "Searching Page")]
    public class SearchPage : SitePageData
    {
    }
}