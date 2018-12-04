using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NitkaWebServer.Models
{
    public class NavLinkViewModel
    {
        public string title { get; set; }
        public string routeName { get; set; }
        public int order { get; set; }
    }
}