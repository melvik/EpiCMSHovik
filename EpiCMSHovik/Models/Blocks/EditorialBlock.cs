using System;
using System.ComponentModel.DataAnnotations;
using EPiServer.Core;
using EPiServer.DataAbstraction;
using EPiServer.DataAnnotations;

namespace EpiCMSHovik.Models.Blocks
{
    [ContentType(DisplayName = "EditorialBlock", GUID = "6cd61d36-7ba6-4846-b071-dad3a72ef42e", Description = "block 1")]
    public class EditorialBlock : BlockData
    {
        [CultureSpecific]
        [Display(
            Name = "Main Body",
            Description = "Name field's description",
            GroupName = SystemTabNames.Content,
            Order = 1)]
        public virtual XhtmlString MainBody { get; set; }
    }
}