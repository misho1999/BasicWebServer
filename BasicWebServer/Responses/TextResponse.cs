using BasicWebServer.HTTP;
using System;

namespace BasicWebServer.Responses
{
    public class TextResponse : ContentResponse
    {
        public TextResponse(string text, Action<Request, Response> preRenderAction = null)
            : base(text, ContentType.PlainText)
        {
        }
    }
}
