using NitkaWebServer.Helpers.Services;

using System.Web.Http;

namespace NitkaWebServer.Controllers
{
    [RoutePrefix("api/admin")]
    public class AdminController : ApiController
    {
        [Route("dashboard"), HttpGet]
        //TODO. Return data
        public string GetDashboard()
        {
            var header = Request.Headers.Authorization;
            if (header != null)
            {
                var isValidToken = TokenService.ValidateToken(header.Parameter);
                if (isValidToken)
                {
                    //Return data
                    return "TEST STRING FROM ADMIN DASHBOARD";
                }
                else
                {
                    throw new HttpResponseException(System.Net.HttpStatusCode.Unauthorized);
                }
            }
            else
            {
                throw new HttpResponseException(System.Net.HttpStatusCode.Unauthorized);
            }
        }
    }
}
