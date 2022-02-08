using BasicWebServer.HTTP;

namespace BasicWebServer.Responses
{
    public class UnauthorizedResponse : Response
    {
        public UnauthorizedResponse()
            : base(StatusCode.Unauthorized)
        {

        }
    }
}
