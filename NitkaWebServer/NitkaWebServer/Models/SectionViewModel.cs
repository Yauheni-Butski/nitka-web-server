using NitkaWebServer.Models.Interfaces;

namespace NitkaWebServer.Models
{
    public class SectionViewModel : IImageCard
    {
        public int id { get; set; }
        public int? parentId { get; set; }
        public string name { get; set; }
        public int order { get; set; }
        public string description { get; set; }
        public string coverImagePath { get; set; }
        public bool isLeaf { get; set; }
    }
}