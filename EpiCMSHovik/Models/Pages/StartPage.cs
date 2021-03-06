﻿using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;

namespace EpiCMSHovik.Models.Pages
{
    [ContentType(DisplayName = "StartPage", GUID = "5763f763-8921-43c5-a9bf-92bef246b41a", Description = "Alloy Start Page")]
    public class StartPage : SitePageData
    {

        [CultureSpecific]
        [Display(
            Name = "Main body",
            Description = "The main body will be shown in the main content area of the page, using the XHTML-editor you can insert for example text, images and tables.",
            GroupName = SystemTabNames.Content,
            Order = 1)]
        public virtual XhtmlString MainBody { get; set; }

        [Display(GroupName = SystemTabNames.Content, Order = 0)]
        public virtual string Heading { get; set; }

        [Display(GroupName = SystemTabNames.Content, Order = 300)]
        public virtual ContentArea MainContentArea { get; set; }

        [Display(
            Name = "Search",
            GroupName = SystemTabNames.Settings)]
        public virtual PageReference SearchPageLink { get; set; }

    }
}