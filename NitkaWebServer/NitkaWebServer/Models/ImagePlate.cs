namespace NitkaWebServer.Models
{
    public class ImagePlate
    {
        public int id { get; set; }
        public string thumbPath { get; set; }
        public string imagePath { get; set; }

        public ImagePlate(int id, string thumbPath, string imagePath)
        {
            this.id = id;
            this.thumbPath = thumbPath;
            this.imagePath = imagePath;
        }
    }
}