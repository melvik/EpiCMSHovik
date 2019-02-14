using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;

namespace EpiCMSHovik.Models.Pages
{
    [ContentType(DisplayName = "FaqItem", GUID = "b1cd47ab-859e-4932-9a37-6baa10c5392d", Description = "FAQ page type", AvailableInEditMode = false)]
    public class FaqItem : SitePageData
    {
        [CultureSpecific]
        [Display(
            Name = "Question",
            Description = "FAQ Question",
            GroupName = SystemTabNames.Content,
            Order = 10)]
        public virtual string Question { get; set; }

        [CultureSpecific]
        [Display(
            Name = "Answer",
            Description = "FAQ Answer",
            GroupName = SystemTabNames.Content,
            Order = 20)]
        public virtual XhtmlString Answer { get; set; }
    }
}