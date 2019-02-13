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
            return sectionsResponceData;
        }
    }
}
