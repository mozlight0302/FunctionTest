using System.Net;

public static async Task<HttpResponseMessage> Run(HttpRequestMessage req, TraceWriter log)
{
    log.Info("Deployment done!!!");

    return req.CreateResponse(HttpStatusCode.OK, "Hello ");
}
