using BasicWebServer.HTTP;

namespace BasicWebServer.Responses
{
    public class BadRequestResponse : Response
    {
        public BadRequestResponse()
            : base(StatusCode.BadRequest)
        {
        }
    }
}
