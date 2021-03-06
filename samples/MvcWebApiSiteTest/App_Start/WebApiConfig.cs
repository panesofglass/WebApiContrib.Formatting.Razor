﻿using System.Web.Http;
using RazorEngine.Configuration;
using WebApiContrib.Formatting.Html;
using WebApiContrib.Formatting.Html.Formatting;
using WebApiContrib.Formatting.Razor;

namespace MvcWebApiSiteTest
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            var viewParser = new RazorViewParser(baseTemplateType: typeof(HtmlTemplateBase<>));
            config.Formatters.Add(new RazorViewFormatter(viewParser: viewParser));

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "{controller}/{id}",
                defaults: new { controller = "Home", id = RouteParameter.Optional }
            );
        }
    }
}
