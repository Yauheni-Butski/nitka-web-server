namespace NitkaWebServer.Models
{
    public class ImagePlate
    {
        public int id { get; set; }
        public string thumbPath { get; set; }
        public string imagePath { get; set; }
        public int likeCount { get; set; }
        public bool isUserLike { get; set; }

        public ImagePlate(int id, string thumbPath, string imagePath, int likeCount, bool isUserLike)
        {
            this.id = id;
            this.thumbPath = thumbPath;
            this.imagePath = imagePath;
            this.likeCount = likeCount;
            this.isUserLike = isUserLike;
        }
    }
}