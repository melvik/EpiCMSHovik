using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using EPiServer.Web;

namespace EpiCMSHovik.Business.Channels
{
    public class MobileChannel : DisplayChannel
    {
        public override bool IsActive(HttpContextBase context)
        {
            return context.Request.Browser.IsMobileDevice;
        }

        public override string ChannelName => "MobileC";

        public override string DisplayName => "MobileD";

        public override string ResolutionId => typeof(MobileResolution).FullName;
    }
}