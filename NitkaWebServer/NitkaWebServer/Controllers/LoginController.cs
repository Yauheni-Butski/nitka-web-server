using Domain.Services;
using NitkaWebServer.Helpers.Services;
using NitkaWebServer.Models;

using System.Web.Http;

namespace NitkaWebServer.Controllers
{
    public class LoginController : ApiController
    {
        [HttpPost, Route("api/login")]
        public LoginResultViewModel Login(LoginViewModel model)
        {
            var isAuthenticated = LoginService.ValidateLoginAndPassword(model.username, model.password);
            string adminUserToken = string.Empty;
            if (isAuthenticated)
            {
                adminUserToken = TokenService.GetAminUserToken();
            }
            else
            {
                //throw new HttpResponseException(System.Net.HttpStatusCode.Unauthorized);
                //только если в клиенте будем обрабатывать .error статус
            }

            LoginResultViewModel responce = new LoginResultViewModel() { success = false };
            if (isAuthenticated)
            {
                responce.success = true;
                responce.userToken = adminUserToken;
            }

            return responce; //return false
        }
    }
}