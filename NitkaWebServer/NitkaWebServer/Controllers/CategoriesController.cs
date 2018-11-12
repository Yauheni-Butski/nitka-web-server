using Domain.Models;
using NitkaWebServer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Helpers;
using System.Web.Http;

namespace NitkaWebServer.Controllers
{
    public class CategoriesController : ApiController
    {
        // GET api/categories
        public IEnumerable<CategoryViewModel> Get() //IEnumerable<Category>
        {
            //var responseData = new Category[] {
            //    new Category() {Id = 1, Description = "TEST 1", DateCreate = DateTime.Now, Name = "TEST 1", Order = 1},
            //     new Category() {Id = 2, Description = "TEST 2", DateCreate = DateTime.Now, Name = "TEST 2", Order = 1},
            //};

            //CategoryViewModel
            var responseData = new CategoryViewModel[] {
                new CategoryViewModel() {id = 1, description = "TEST 1", name = "TEST 1", order = 1},
                 new CategoryViewModel() {id = 2, description = "TEST 2", name = "TEST 2", order = 1},
            };

            return responseData;
        }
    }
}
