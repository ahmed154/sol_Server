using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading;
using System.Threading.Tasks;

namespace pro_Server.Handlers
{
    public class ValidateHeaderHandler : DelegatingHandler
    {
        protected override async Task<HttpResponseMessage> SendAsync(HttpRequestMessage httpRequestMessage, CancellationToken cancellationToken)
        {
            if(!httpRequestMessage.Headers.Contains("Authorization"))
            {
                return new HttpResponseMessage(System.Net.HttpStatusCode.BadRequest);
            }
            return await base.SendAsync(httpRequestMessage, cancellationToken);
        }
    }
}
