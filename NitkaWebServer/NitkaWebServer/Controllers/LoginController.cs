using Domain.Services;
using NitkaWebServer.Models;
using System.Web.Http;

namespace NitkaWebServer.Controllers
{
    public class LoginController : ApiController
    {
        [HttpPost, Route("api/login")]
        public bool Login(LoginViewModel model)
        {
            var isAuthenticated = LoginService.ValidateLoginAndPassword(model.username, model.password);
            if (isAuthenticated)
            {

            }
            else
            {

            }

            var isCanLogin = isAuthenticated; //model.username == "admin" && model.password == "admin";
            return isCanLogin; //return false
        }
    }
}