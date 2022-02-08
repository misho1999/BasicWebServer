using BasicWebServer.HTTP;
using System;

namespace BasicWebServer.Routing
{
    public interface IRoutingTable
    {
        IRoutingTable Map(Method method, string path ,Func<Request, Response> responseFunction);

    }
}
