﻿using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;
using EPiServer.SpecializedProperties;
using EPiServer.Web;

namespace EpiCMSHovik.Models.Pages
{
    [ContentType(DisplayName = "ProductPage", GUID = "b2642c83-7b48-4489-b5d8-9893d1b00b74", Description = "Hovik Product Page")]
    public class ProductPage : StandardPage
    {
        [CultureSpecific]
        [Display(GroupName = SystemTabNames.Content, Order = 305)]
        [UIHint(UIHint.Textarea)]
        public virtual string UniqueSellingPoint { get; set; }
        /*
                [CultureSpecific]
                [Display(
                    Name = "Main body",
                    Description = "The main body will be shown in the main content area of the page, using the XHTML-editor you can insert for example text, images and tables.",
                    GroupName = SystemTabNames.Content,
                    Order = 1)]
                public virtual XhtmlString MainBody { get; set; }
         */
    }
}