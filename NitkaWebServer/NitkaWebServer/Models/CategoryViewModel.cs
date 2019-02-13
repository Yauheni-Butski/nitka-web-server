using NitkaWebServer.Models.Interfaces;

namespace NitkaWebServer.Models
{
    public class CategoryViewModel
    {
        public NavLinkViewModel[] navLinks { get; set; }
        public IImageCard[] categoryCards { get; set; }
    }
}