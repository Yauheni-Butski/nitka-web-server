using NitkaWebServer.Models;
using NitkaWebServer.Models.Interfaces;
using System.Collections.Generic;
using System.Linq;
using System.Web.Http;

namespace NitkaWebServer.Controllers
{
    public class CategoriesController : ApiController
    {
        // GET api/categories
        [Route("api/categories/{id?}")]
        public IEnumerable<IImageCard> GetCategories(int? id = null)
        {
            var allCategories = new CategoryViewModel[] {
                new CategoryViewModel() {id = 1, parentId = null, description = "TEST description", name = "Portraits", order = 1, coverImagePath = Url.Content("~/Assets/Images/photo37-600x400.jpg")},
                new CategoryViewModel() {id = 2, parentId = null, isLeaf = true, description = "TEST description", name = "Women", order = 1, coverImagePath = Url.Content("~/Assets/Images/photo48-644x900.jpg")},
                new CategoryViewModel() {id = 3, parentId = null, isLeaf = true, description = "TEST description", name = "Wedding", order = 1, coverImagePath = Url.Content("~/Assets/Images/photo50-599x900.jpg")},
                new CategoryViewModel() {id = 4, parentId = null, isLeaf = true, description = "TEST description", name = "Crazies", order = 1, coverImagePath = Url.Content("~/Assets/Images/photo53-600x400.jpg")},
                new CategoryViewModel() {id = 5, parentId = null, isLeaf = true, description = "TEST description", name = "Mens", order = 1, coverImagePath = Url.Content("~/Assets/Images/photo61-600x400.jpg")},
                new CategoryViewModel() {id = 6, parentId = null, isLeaf = true, description = "TEST description", name = "Pidors", order = 1, coverImagePath = Url.Content("~/Assets/Images/photo63-600x398.jpg")},
                new CategoryViewModel() {id = 7, parentId = 1, isLeaf = true, description = "TEST description", name = "Homeless", order = 1, coverImagePath = Url.Content("~/Assets/Images/photo67-600x377.jpg")},
                new CategoryViewModel() {id = 8, parentId = 1, isLeaf = true, description = "TEST description", name = "Battle", order = 1, coverImagePath = Url.Content("~/Assets/Images/photo69-600x375.jpg")},
                new CategoryViewModel() {id = 9, parentId = 1, isLeaf = true, description = "TEST description", name = "Brutal", order = 1, coverImagePath = Url.Content("~/Assets/Images/photo37-600x400.jpg")},
                new CategoryViewModel() {id = 10, parentId = 1, isLeaf = true,description = "TEST description", name = "Women", order = 1, coverImagePath = Url.Content("~/Assets/Images/photo48-644x900.jpg")},
                //new CategoryViewModel() {id = 11, description = "TEST description", name = "Wedding", order = 1, coverImagePath = Url.Content("~/Assets/Images/photo50-599x900.jpg")},
                //new CategoryViewModel() {id = 12, description = "TEST description", name = "Crazies", order = 1, coverImagePath = Url.Content("~/Assets/Images/photo53-600x400.jpg")},
                //new CategoryViewModel() {id = 13, description = "TEST description", name = "Mens", order = 1, coverImagePath = Url.Content("~/Assets/Images/photo61-600x400.jpg")},
                //new CategoryViewModel() {id = 14, description = "TEST description", name = "Pidors", order = 1, coverImagePath = Url.Content("~/Assets/Images/photo63-600x398.jpg")},
                //new CategoryViewModel() {id = 15, description = "TEST description", name = "Homeless", order = 1, coverImagePath = Url.Content("~/Assets/Images/photo67-600x377.jpg")},
            };

            //1. Find categories that have parentId == id
            var subCategories = allCategories.Where(x => x.parentId == id);

            //prepare to return categories
            return subCategories;
        }
    }
}
