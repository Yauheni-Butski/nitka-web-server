namespace NitkaWebServer.Models
{
    public class CategoryViewModel
    {
        public int id { get; set; }
        public int? parentId { get; set; }
        public string name { get; set; }
        public int order { get; set; }
        public string description { get; set; }
        public string coverImagePath { get; set; }
    }
}