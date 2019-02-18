using NitkaWebServer.Models.Interfaces;

namespace NitkaWebServer.Models
{
    public class SectionViewModel
    {
        public NavLinkViewModel[] navLinks { get; set; }
        public ImagePlate[] imagePlates { get; set; }
    }
}