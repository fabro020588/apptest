using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;
using test.Core;

namespace test.Handler
{
  public class MessageHandler : DelegatingHandler
  {
    protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage request, CancellationToken cancellationToken)
    {
      if (request.Headers.TryGetValues("X-Parse-REST-API-Key", out IEnumerable<string> requestHeader))
      {
        if (!requestHeader.FirstOrDefault().Equals(MessageEndPoint.GetApiKey()))
          return request.CreateResponse(HttpStatusCode.Forbidden, "Invalid API key");
      }
      return await base.SendAsync(request, cancellationToken);
    }
  }
}