using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;

namespace EpiCMSHovik.Models.Blocks
{
    [ContentType(DisplayName = "ListingBlock", GUID = "8839e9af-c870-4e0c-8a12-d1dddd1ddb78", Description = "")]
    public class ListingBlock : BlockData
    {
        [Display(
            GroupName = SystemTabNames.Content,
            Order = 100)]
        public virtual String Heading { get; set; }

        [Display(
            GroupName = SystemTabNames.Content,
            Order = 200)]
        public virtual PageReference RootPage { get; set; }
    }
}