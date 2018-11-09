using Domain.Models;
using System;
using System.Collections.Generic;
using System.Web.Http;

namespace NitkaWebServer.Controllers
{
    public class CategoriesController : ApiController
    {
        // GET api/categories
        public IEnumerable<Category> Get()
        {
            return new Category[] {
                new Category() {Id = 1, Description = "TEST 1", DateCreate = DateTime.Now, Name = "TEST 1", Order = 1},
                 new Category() {Id = 2, Description = "TEST 2", DateCreate = DateTime.Now, Name = "TEST 2", Order = 1},
            };
        }
    }
}
