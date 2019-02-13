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
        // GET api/section
        [Route("api/section/{id:int}")]
        public SectionViewModel GetSection(int id)
        {
            var sectionsResponceData = new SectionViewModel { };
            switch (id)
            {
                //TODO. Do we need return special nav links for special category?
                default:
                    sectionsResponceData = new SectionViewModel
                    {
                        navLinks = new NavLinkViewModel[] {
                            new NavLinkViewModel() { title = "Главная", routeName = "", order = 1 },
                            new NavLinkViewModel() { title = "Услуги", routeName = "services", order = 2 },
                            new NavLinkViewModel() { title = "Серии", routeName = "series", order = 3 },
                            new NavLinkViewModel() { title = "Полезные советы", routeName = "advices", order = 4 }
                        }
                    };
                    break;
            }
            return sectionsResponceData;
        }
    }
}
