using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;

namespace EpiCMSHovik.Models.Pages
{
    [ContentType(DisplayName = "FaqPage", GUID = "21f5d6ad-139a-4172-b07b-cce46429979f", Description = "")]
    public class FaqPage : SitePageData
    {
        [Ignore]
        public IList<FaqItem> FaqItems { get; set; }
    }
}