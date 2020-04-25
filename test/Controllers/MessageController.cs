using System.Net;
using System.Web.Http;
using test.Core;
using test.Models;

namespace test.Controllers
{
  /// <summary>
  /// message controller class for process message
  /// </summary>
  [AllowAnonymous]
  public class MessageController : ApiController
  {
    [HttpPost]
    [Route("process")]
    public IHttpActionResult Process(MessageRequest element)
    {
      if (element == null) throw new HttpResponseException(HttpStatusCode.BadRequest);
      return Ok(new { message = MessageEndPoint.LoadMessage(element) });
    }
  }
}
