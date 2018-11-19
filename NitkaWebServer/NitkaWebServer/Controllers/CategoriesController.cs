using NitkaWebServer.Models;
using System.Collections.Generic;
using System.Web.Http;

namespace NitkaWebServer.Controllers
{
    public class CategoriesController : ApiController
    {
        // GET api/categories
        [Route("api/categories")]
        public IEnumerable<CategoryViewModel> Get()
        {
            var responseData = new CategoryViewModel[] {
                new CategoryViewModel() {id = 1, description = "TEST description", name = "Brutal", order = 1, coverImagePath = Url.Content("~/Assets/Images/photo37-600x400.jpg")},
                new CategoryViewModel() {id = 2, description = "TEST description", name = "Women", order = 1, coverImagePath = Url.Content("~/Assets/Images/photo48-644x900.jpg")},
                new CategoryViewModel() {id = 3, description = "TEST description", name = "Wedding", order = 1, coverImagePath = Url.Content("~/Assets/Images/photo50-599x900.jpg")},
                new CategoryViewModel() {id = 4, description = "TEST description", name = "Crazies", order = 1, coverImagePath = Url.Content("~/Assets/Images/photo53-600x400.jpg")},
                new CategoryViewModel() {id = 5, description = "TEST description", name = "Mens", order = 1, coverImagePath = Url.Content("~/Assets/Images/photo61-600x400.jpg")},
                new CategoryViewModel() {id = 6, description = "TEST description", name = "Pidors", order = 1, coverImagePath = Url.Content("~/Assets/Images/photo63-600x398.jpg")},
                new CategoryViewModel() {id = 7, description = "TEST description", name = "Homeless", order = 1, coverImagePath = Url.Content("~/Assets/Images/photo67-600x377.jpg")},
                new CategoryViewModel() {id = 8, description = "TEST description", name = "Battle", order = 1, coverImagePath = Url.Content("~/Assets/Images/photo69-600x375.jpg")},
                new CategoryViewModel() {id = 9, description = "TEST description", name = "Brutal", order = 1, coverImagePath = Url.Content("~/Assets/Images/photo37-600x400.jpg")},
                new CategoryViewModel() {id = 10, description = "TEST description", name = "Women", order = 1, coverImagePath = Url.Content("~/Assets/Images/photo48-644x900.jpg")},
                new CategoryViewModel() {id = 11, description = "TEST description", name = "Wedding", order = 1, coverImagePath = Url.Content("~/Assets/Images/photo50-599x900.jpg")},
                new CategoryViewModel() {id = 12, description = "TEST description", name = "Crazies", order = 1, coverImagePath = Url.Content("~/Assets/Images/photo53-600x400.jpg")},
                new CategoryViewModel() {id = 13, description = "TEST description", name = "Mens", order = 1, coverImagePath = Url.Content("~/Assets/Images/photo61-600x400.jpg")},
                new CategoryViewModel() {id = 14, description = "TEST description", name = "Pidors", order = 1, coverImagePath = Url.Content("~/Assets/Images/photo63-600x398.jpg")},
                new CategoryViewModel() {id = 15, description = "TEST description", name = "Homeless", order = 1, coverImagePath = Url.Content("~/Assets/Images/photo67-600x377.jpg")},
            };

            return responseData;
        }

        [Route("api/categories/{id}")]
        public IEnumerable<SectionViewModel> GetCategorySection(int id)
        {
            var responceData = new SectionViewModel[] { };

            switch (id)
            {
                case 1:
                    responceData = new SectionViewModel[] {
                        new SectionViewModel() {id = 1, description = "TEST description", name = "Brutal", order = 1, coverImagePath = Url.Content("~/Assets/Images/photo37-600x400.jpg")},
                        new SectionViewModel() {id = 2, description = "TEST description", name = "Women", order = 1, coverImagePath = Url.Content("~/Assets/Images/photo48-644x900.jpg")},
                        new SectionViewModel() {id = 3, description = "TEST description", name = "Wedding", order = 1, coverImagePath = Url.Content("~/Assets/Images/photo50-599x900.jpg")},
                    };
                    break;
                case 2:
                    responceData = new SectionViewModel[] {
                        new SectionViewModel() {id = 4, description = "TEST description", name = "Crazies", order = 1, coverImagePath = Url.Content("~/Assets/Images/photo53-600x400.jpg")},
                        new SectionViewModel() {id = 5, description = "TEST description", name = "Mens", order = 1, coverImagePath = Url.Content("~/Assets/Images/photo61-600x400.jpg")},
                        new SectionViewModel() {id = 6, description = "TEST description", name = "Pidors", order = 1, coverImagePath = Url.Content("~/Assets/Images/photo63-600x398.jpg")},
                    };
                    break;
                case 3:
                    responceData = new SectionViewModel[] {
                        new SectionViewModel() {id = 7, description = "TEST description", name = "Homeless", order = 1, coverImagePath = Url.Content("~/Assets/Images/photo67-600x377.jpg")},
                        new SectionViewModel() {id = 8, description = "TEST description", name = "Battle", order = 1, coverImagePath = Url.Content("~/Assets/Images/photo69-600x375.jpg")},
                        new SectionViewModel() {id = 9, description = "TEST description", name = "Brutal", order = 1, coverImagePath = Url.Content("~/Assets/Images/photo37-600x400.jpg")},
                    };
                    break;
                default:
                    break;
            }

            return responceData;
        }
    }
}
