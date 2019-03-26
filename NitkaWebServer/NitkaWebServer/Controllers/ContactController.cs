using NitkaWebServer.Models;
using System.Web.Http;

namespace NitkaWebServer.Controllers
{
    public class ContactController : ApiController
    {
        [HttpPost, Route("api/contact")]
        public SubmitResultViewModel ContactForm_Submit(ContactViewModel model)
        {
            var responce = new SubmitResultViewModel() { success = true, message = "Ваше сообщение успешно доставлено." };
            return responce;
        }
    }
}
