namespace NitkaWebServer.Models.Interfaces
{
    public interface IImageCard
    {
        int id { get; set; }
        int? parentId { get; set; }
        string name { get; set; }
        int order { get; set; }
        string description { get; set; }
        string coverImagePath { get; set; }
        bool isLeaf { get; set; }
    }
}