using NitkaWebServer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace NitkaWebServer.Controllers
{
    public class SectionController : ApiController
    {
        //TODO. VOID FOR TEMP
        // GET api/section
        [Route("api/section/{id:int}")]
        public SectionViewModel GetSection(int id)
        {
            //2. If not subCategories, return sections
            var sectionsResponceData = new SectionViewModel { };
            switch (id)
            {
                case 7:
                    sectionsResponceData = new SectionViewModel {
                        navLinks = new NavLinkViewModel[] {
                            new NavLinkViewModel() { title = "Главная", routeName = "", order = 1 },
                            new NavLinkViewModel() { title = "Услуги", routeName = "services", order = 2 },
                            new NavLinkViewModel() { title = "Серии", routeName = "series", order = 3 },
                            new NavLinkViewModel() { title = "Полезные советы", routeName = "advices", order = 4 }
                        }
                    };
                    break;
                //case 8:
                //    sectionsResponceData = new SectionViewModel[] {
                //        new SectionViewModel() {id = 4, description = "TEST description", name = "Crazies", order = 1, coverImagePath = Url.Content("~/Assets/Images/photo53-600x400.jpg")},
                //        new SectionViewModel() {id = 5, description = "TEST description", name = "Mens", order = 1, coverImagePath = Url.Content("~/Assets/Images/photo61-600x400.jpg")},
                //        new SectionViewModel() {id = 6, description = "TEST description", name = "Pidors", order = 1, coverImagePath = Url.Content("~/Assets/Images/photo63-600x398.jpg")},
                //    };
                //    break;
                default:
                    break;
            }

            return sectionsResponceData;
        }
    }
}
