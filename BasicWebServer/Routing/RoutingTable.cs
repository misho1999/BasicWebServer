using BasicWebServer.HTTP;
using BasicWebServer.Responses;
using System;
using System.Collections.Generic;

namespace BasicWebServer.Routing
{
    public class RoutingTable : IRoutingTable
    {
        private readonly Dictionary<Method, Dictionary<string, Func<Request, Response>>> routes;

        public RoutingTable() =>
            this.routes = new()                      //OR ---> new Dictionary<Method, Dictionary<string, Response>>()
            {
                [Method.Get] = new(),              //OR ---> new Dictionary<string, Response>(),
                [Method.Post] = new(),            //OR ---> new Dictionary<string, Response>(),
                [Method.Put] = new(),           //OR ---> new Dictionary<string, Response>(),
                [Method.Delete] = new()         //OR ---> new Dictionary<string, Response>()

            };
        public IRoutingTable Map(Method method, string path, Func<Request, Response> responseFunction)
        {

            Guard.AgainstNull(path, nameof(path));
            Guard.AgainstNull(responseFunction, nameof(responseFunction));

            this.routes[method][path] = responseFunction;

            switch (method)
            {
                case Method.Get:
                    return MapGet(path, responseFunction);
                case Method.Post:
                    return MapPost(path, responseFunction);
                case Method.Put:
                case Method.Delete:
                default:
                    throw new ArgumentException($"The method {nameof(method)} is not supported!");

            }

        }

        private IRoutingTable MapGet(
            string path,
            Func<Request, Response> responseFuntion)
        {
            routes[Method.Get][path] = responseFuntion;
            return this;
        }



        private IRoutingTable MapPost(
            string path,
            Func<Request, Response> responseFuntion)
        {
            routes[Method.Post][path] = responseFuntion;
            return this;
        }


        public Response MatchRequest(Request request)
        {
            var requestMethod = request.Method;
            var requestUrl = request.Url;

            if (!this.routes.ContainsKey(requestMethod) || !this.routes[requestMethod].ContainsKey(requestUrl))
            {
                return new NotFoundResponse();
            }

            var responseFunction = this.routes[requestMethod][requestUrl];

            return responseFunction(request);
        }
    }
}
