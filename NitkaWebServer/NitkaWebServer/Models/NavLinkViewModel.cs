namespace NitkaWebServer.Models
{
    public class NavLinkViewModel
    {
        public string title { get; set; }
        public string relativeUrl { get; set; }
        public int order { get; set; }

        public NavLinkViewModel(string title, string relativeUrl, int order)
        {
            this.title = title;
            this.relativeUrl = relativeUrl;
            this.order = order;
        }
    }
}