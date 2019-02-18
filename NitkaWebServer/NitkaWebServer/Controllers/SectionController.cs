using NitkaWebServer.Models;
using System.Web.Http;

namespace NitkaWebServer.Controllers
{
    public class SectionController : ApiController
    {
        // GET api/section
        [Route("api/section/{id:int}")]
        public SectionViewModel GetSection(int id)
        {
            var sectionsResponceData = new SectionViewModel { };
            switch (id)
            {
                //TODO. Do we need return special nav links for special category?
                case 7:
                    //TODO. Get section parent category id
                    int sectionCategoryId = 1;
                    sectionsResponceData = new SectionViewModel
                    {
                        navLinks = new NavLinkViewModel[] {
                            new NavLinkViewModel(title: "Главная", relativeUrl: "/", order: 1),
                            new NavLinkViewModel(title: "Услуги", relativeUrl: "./services", order: 2),
                            new NavLinkViewModel(title: "Серии", relativeUrl: $"/category/{sectionCategoryId}", order: 3),
                            new NavLinkViewModel(title: "Полезные советы", relativeUrl: "./advices", order: 4)
                        }
                    };
                    break;
                default:
                    sectionsResponceData = new SectionViewModel
                    {
                        navLinks = new NavLinkViewModel[] {
                            new NavLinkViewModel(title: "Главная", relativeUrl: "/", order: 1),
                            new NavLinkViewModel(title: "Услуги", relativeUrl: "./services", order: 2),
                            new NavLinkViewModel(title: "Полезные советы", relativeUrl: "./advices", order: 4)
                        }
                    };
                    break;
            }

            //temp, add inner images for all section
            sectionsResponceData.imagePlates = new ImagePlate[]
            {
                new ImagePlate(id: 1, thumbPath: Url.Content("~/Assets/Images/photo37-600x400.jpg"), imagePath: Url.Content("~/Assets/Images/photo37-600x400.jpg")),
                new ImagePlate(id: 2, thumbPath: Url.Content("~/Assets/Images/photo48-644x900.jpg"), imagePath: Url.Content("~/Assets/Images/photo48-644x900.jpg")),
                new ImagePlate(id: 3, thumbPath: Url.Content("~/Assets/Images/photo50-599x900.jpg"), imagePath: Url.Content("~/Assets/Images/photo50-599x900.jpg")),
                new ImagePlate(id: 4, thumbPath: Url.Content("~/Assets/Images/photo53-600x400.jpg"), imagePath: Url.Content("~/Assets/Images/photo53-600x400.jpg")),
                new ImagePlate(id: 5, thumbPath: Url.Content("~/Assets/Images/photo61-600x400.jpg"), imagePath: Url.Content("~/Assets/Images/photo61-600x400.jpg")),
                new ImagePlate(id: 6, thumbPath: Url.Content("~/Assets/Images/photo63-600x398.jpg"), imagePath: Url.Content("~/Assets/Images/photo63-600x398.jpg")),
                new ImagePlate(id: 7, thumbPath: Url.Content("~/Assets/Images/photo67-600x377.jpg"), imagePath: Url.Content("~/Assets/Images/photo67-600x377.jpg")),
                new ImagePlate(id: 8, thumbPath: Url.Content("~/Assets/Images/photo69-600x375.jpg"), imagePath: Url.Content("~/Assets/Images/photo69-600x375.jpg")),
                new ImagePlate(id: 9, thumbPath: Url.Content("~/Assets/Images/photo37-600x400.jpg"), imagePath: Url.Content("~/Assets/Images/photo37-600x400.jpg")),
                new ImagePlate(id: 10, thumbPath: Url.Content("~/Assets/Images/photo48-644x900.jpg"), imagePath: Url.Content("~/Assets/Images/photo48-644x900.jpg")),
                new ImagePlate(id: 11, thumbPath: Url.Content("~/Assets/Images/photo37-600x400.jpg"), imagePath: Url.Content("~/Assets/Images/photo37-600x400.jpg")),
                new ImagePlate(id: 12, thumbPath: Url.Content("~/Assets/Images/photo48-644x900.jpg"), imagePath: Url.Content("~/Assets/Images/photo48-644x900.jpg")),
                new ImagePlate(id: 13, thumbPath: Url.Content("~/Assets/Images/photo50-599x900.jpg"), imagePath: Url.Content("~/Assets/Images/photo50-599x900.jpg")),
                new ImagePlate(id: 14, thumbPath: Url.Content("~/Assets/Images/photo53-600x400.jpg"), imagePath: Url.Content("~/Assets/Images/photo53-600x400.jpg")),
                new ImagePlate(id: 15, thumbPath: Url.Content("~/Assets/Images/photo61-600x400.jpg"), imagePath: Url.Content("~/Assets/Images/photo61-600x400.jpg")),
                new ImagePlate(id: 16, thumbPath: Url.Content("~/Assets/Images/photo63-600x398.jpg"), imagePath: Url.Content("~/Assets/Images/photo63-600x398.jpg")),
                new ImagePlate(id: 17, thumbPath: Url.Content("~/Assets/Images/photo67-600x377.jpg"), imagePath: Url.Content("~/Assets/Images/photo67-600x377.jpg")),
                new ImagePlate(id: 18, thumbPath: Url.Content("~/Assets/Images/photo69-600x375.jpg"), imagePath: Url.Content("~/Assets/Images/photo69-600x375.jpg")),
                new ImagePlate(id: 19, thumbPath: Url.Content("~/Assets/Images/photo37-600x400.jpg"), imagePath: Url.Content("~/Assets/Images/photo37-600x400.jpg")),
                new ImagePlate(id: 20, thumbPath: Url.Content("~/Assets/Images/photo48-644x900.jpg"), imagePath: Url.Content("~/Assets/Images/photo48-644x900.jpg")),
                new ImagePlate(id: 21, thumbPath: Url.Content("~/Assets/Images/photo37-600x400.jpg"), imagePath: Url.Content("~/Assets/Images/photo37-600x400.jpg")),
            };
            return sectionsResponceData;
        }
    }
}
