﻿using System.Threading.Tasks;

namespace BasicWebServer.Demo
{
    public class StartUp
    {



        private const string Username = "user";

        private const string Password = "user123";
        public static async Task Main()
        {
            //await new HttpServer(routes => routes
            //.MapGet<HomeController>("/", c => c.Index())
            //.MapGet<HomeController>("/Redirect", c => c.Redirect())
            //.MapGet<HomeController>("/HTML", c => c.Html())
            //.MapPost<HomeController>("/HTML", c => c.HtmlFormPost())
            //.MapGet<HomeController>("/Content", c => c.Content())
            //.MapPost<HomeController>("/Content", c => c.DownloadContent())
            //.MapGet<HomeController>("/Cookies", c => c.Cookies())
            //.MapGet<HomeController>("/Session", c => c.Session()))
            //.Start();

        }

        //-------------------------------------------------------------------------------------------------------------------
        //var server = new HttpServer(routes => routes()
        //.MapGet("/", new TextResponse("Hello from the server!"))
        //.MapGet("/Redirect", new RedirectResponse("https://softuni.bg/"))
        //.MapGet("/HTML", new HtmlResponse(StartUp.HtmlForm))
        //.MapPost("/HTML", new TextResponse("", StartUp.AddFormDataAction))
        //.MapGet("/Content", new HtmlResponse(StartUp.DownloadForm))
        //.MapPost("/Content", new TextFileResponse(StartUp.FileName))
        //.MapGet("/Cookies", new HtmlResponse("", StartUp.AddCookiesAction))
        //.MapGet("/Session", new TextResponse("", StartUp.DisplaySessionInfoAction))
        //.MapGet("/Login", new HtmlResponse(StartUp.LoginForm))
        //.MapPost("/Login", new HtmlResponse("", StartUp.LoginAction))
        //.MapGet("/Logout", new HtmlResponse("", StartUp.LogoutAction))
        //.MapGet("/Logout", new HtmlResponse("", StartUp.GetUserDataAction)));

        //await server.Start();

        //--------------------------------------------------------------------------------------------------------------------
        //private static void AddFormDataAction(Request request, Response response)
        //{
        //    response.Body = "";

        //    foreach (var (key, value) in request.Form)
        //    {
        //        response.Body += $"{key} - {value}";
        //        response.Body += Environment.NewLine;
        //    }
        //}
        //-------------------------------------------------------------------------------------------------------------------
        //private static void AddCookiesAction(Request request, Response response)
        //{
        //    var requestHasCookies = request.Cookies.Any(c => c.Name != Session.SessionCookieName);

        //    var bodyText = "";

        //    if (requestHasCookies)
        //    {
        //        var cookieText = new StringBuilder();

        //        cookieText.AppendLine("<h1>Cookies</h1>");

        //        cookieText.Append("<table border='1'><tr><th>Name</th><th>Value</th></tr>");

        //        foreach (var cookie in request.Cookies)
        //        {
        //            cookieText.Append("<tr>");

        //            cookieText.Append($"<td>{HttpUtility.HtmlEncode(cookie.Name)}</td>");

        //            cookieText.Append($"<td>{HttpUtility.HtmlEncode(cookie.Value)}</td>");

        //            //cookieText.Append("/tr>");
        //        }
        //        cookieText.Append("</table>");

        //        bodyText = cookieText.ToString();
        //    }
        //    else
        //    {
        //        bodyText = "<h1>Cookies set!</h1>";
        //    }

        //    if (!requestHasCookies)
        //    {
        //        response.Cookies.Add("My-Cookie", "My-Value");

        //        response.Cookies.Add("My-Second-Cookie", "My-Second-Value");
        //    }

        //    response.Body = bodyText;
        //}
        //-------------------------------------------------------------------------------------------------------------------------
        //private static void LoginAction(Request request, Response response)
        //{
        //    request.Session.Clear();

        //    var bodyText = "";

        //    var usernameMatches = request.Form["Username"] == StartUp.Username;
        //    var passwordMatches = request.Form["Password"] == StartUp.Password;

        //    if (usernameMatches && passwordMatches)
        //    {
        //        request.Session[Session.SessionUserKey] = "MyUserId";

        //        response.Cookies.Add(Session.SessionCookieName, request.Session.Id);

        //        bodyText = "<h3>Logged Successfully!</h3>";
        //    }
        //    else
        //    {
        //        bodyText = StartUp.LoginForm;
        //    }

        //    response.Body = "";
        //    response.Body += bodyText;
        //}
        //-----------------------------------------------------------------------------------------------------------------------
        //private static void LogoutAction(Request request, Response response)
        //{
        //    request.Session.Clear();

        //    response.Body = "";
        //    response.Body += "<h3>Logged out successfully!</h3>";
        //}
        //-------------------------------------------------------------------------------------------------------------------------
        //private static void GetUserDataAction(Request request, Response response)
        //{
        //    if (request.Session.ContainsKey(Session.SessionUserKey))
        //    {
        //        response.Body = "";
        //        response.Body += $"<h3>Currently logged-in user " + $"is with username '{Username}'</h3>";
        //    }
        //    else
        //    {
        //        response.Body = "";
        //        response.Body += $"<h3>You should first log in" + $"- <a href='/Login'>Login</a></h3>";
        //    }
        //}
        //---------------------------------------------------------------------------------------------------------------------------
        //private static void DisplaySessionInfoAction(Request request, Response response)
        //{
        //    var sessionExists = request.Session
        //        .ContainsKey(Session.SessionCurrentDateKey);

        //    var bodyText = "";

        //    if (sessionExists)
        //    {
        //        var currentDate = request.Session[Session.SessionCurrentDateKey];

        //        bodyText = $"Stored date: {currentDate}!";
        //    }
        //    else
        //    {
        //        bodyText = "Current date stored!";
        //    }

        //    response.Body = "";
        //    response.Body += bodyText;
        //}
        //--------------------------------------------------------------------------------------------------------------------------
        //private static async Task<string> DownloadWebSiteContent(string url)
        //{
        //    var httpClient = new HttpClient();

        //    using (httpClient)
        //    {
        //        var response = await httpClient.GetAsync(url);

        //        var html = await response.Content.ReadAsStringAsync();

        //        return html.Substring(0, 2000);
        //    }
        //}
        //----------------------------------------------------------------------------------------------------------------------------
        //private static async Task DownloadSitesAsTextFile(string fileName, string[] urls)
        //{
        //    var downloads = new List<Task<string>>();

        //    foreach (var url in urls)
        //    {
        //        downloads.Add(DownloadWebSiteContent(url));
        //    }

        //    var responses = await Task.WhenAll(downloads);

        //    var responsesString = string.Join(Environment.NewLine + new String('-', 100), responses);

        //    await File.WriteAllTextAsync(fileName, responsesString);
        //}

    }

}
