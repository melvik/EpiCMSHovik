using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EPiServer.Core;

namespace EpiCMSHovik.Models.ViewModels
{
    public class ListingBlockModel
    {
        public String Heading { get; set; }
        public IEnumerable<PageData> Items { get; set; }
    }
}