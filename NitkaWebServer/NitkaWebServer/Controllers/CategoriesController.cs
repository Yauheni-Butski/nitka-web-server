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
        public CategoryViewModel GetCategories(int? id = null)
        {
            var categoryNavLinks = new NavLinkViewModel[] {
                            new NavLinkViewModel(title: "Главная", relativeUrl: "/", order: 1),
                            new NavLinkViewModel(title: "Услуги", relativeUrl: "./services", order: 2),
                            new NavLinkViewModel(title: "Полезные советы", relativeUrl: "./advices", order: 4)};

            var allCategoryCards = new CategoryCard[] {
                new CategoryCard() {id = 1, parentId = null, isLeaf = false, description = "TEST description", name = "Portraits", order = 1, coverImagePath = Url.Content("~/Assets/Images/photo37-600x400.jpg")},
                new CategoryCard() {id = 2, parentId = null, isLeaf = true, description = "TEST description", name = "Women", order = 1, coverImagePath = Url.Content("~/Assets/Images/photo48-644x900.jpg")},
                new CategoryCard() {id = 3, parentId = null, isLeaf = true, description = "TEST description", name = "Wedding", order = 1, coverImagePath = Url.Content("~/Assets/Images/photo50-599x900.jpg")},
                new CategoryCard() {id = 4, parentId = null, isLeaf = true, description = "TEST description", name = "Crazies", order = 1, coverImagePath = Url.Content("~/Assets/Images/photo53-600x400.jpg")},
                new CategoryCard() {id = 5, parentId = null, isLeaf = true, description = "TEST description", name = "Mens", order = 1, coverImagePath = Url.Content("~/Assets/Images/photo61-600x400.jpg")},
                new CategoryCard() {id = 6, parentId = null, isLeaf = true, description = "TEST description", name = "Pidors", order = 1, coverImagePath = Url.Content("~/Assets/Images/photo63-600x398.jpg")},
                new CategoryCard() {id = 7, parentId = 1, isLeaf = true, description = "TEST description", name = "Homeless", order = 1, coverImagePath = Url.Content("~/Assets/Images/photo67-600x377.jpg")},
                new CategoryCard() {id = 8, parentId = 1, isLeaf = true, description = "TEST description", name = "Battle", order = 1, coverImagePath = Url.Content("~/Assets/Images/photo69-600x375.jpg")},
                new CategoryCard() {id = 9, parentId = 1, isLeaf = true, description = "TEST description", name = "Brutal", order = 1, coverImagePath = Url.Content("~/Assets/Images/photo37-600x400.jpg")},
                new CategoryCard() {id = 10, parentId = 1, isLeaf = true,description = "TEST description", name = "Women", order = 1, coverImagePath = Url.Content("~/Assets/Images/photo48-644x900.jpg")},
                //new CategoryCard() {id = 11, description = "TEST description", name = "Wedding", order = 1, coverImagePath = Url.Content("~/Assets/Images/photo50-599x900.jpg")},
                //new CategoryCard() {id = 12, description = "TEST description", name = "Crazies", order = 1, coverImagePath = Url.Content("~/Assets/Images/photo53-600x400.jpg")},
                //new CategoryCard() {id = 13, description = "TEST description", name = "Mens", order = 1, coverImagePath = Url.Content("~/Assets/Images/photo61-600x400.jpg")},
                //new CategoryCard() {id = 14, description = "TEST description", name = "Pidors", order = 1, coverImagePath = Url.Content("~/Assets/Images/photo63-600x398.jpg")},
                //new CategoryCard() {id = 15, description = "TEST description", name = "Homeless", order = 1, coverImagePath = Url.Content("~/Assets/Images/photo67-600x377.jpg")},
            };

            //2. Find categories that have parentId == id
            var categoryCards = allCategoryCards.Where(x => x.parentId == id);

            //prepare to return category content
            var category = new CategoryViewModel()
            {
                navLinks = id == null ? null : categoryNavLinks,
                categoryCards = categoryCards.ToArray()
            };

            return category;
        }
    }
}
