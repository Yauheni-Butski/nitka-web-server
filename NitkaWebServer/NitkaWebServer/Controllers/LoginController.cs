using NitkaWebServer.Models;
using System.Web.Http;

namespace NitkaWebServer.Controllers
{
    public class LoginController : ApiController
    {
        [HttpPost, Route("api/login")]
        public bool Login(LoginViewModel model)
        {
            var isCanLogin = model.username == "admin" && model.password == "admin";
            return isCanLogin; //return false
        }
    }
}