
using System;
using System.Linq;
using System.Web;

namespace HealthCheck
{
    public class HealthModule : IHttpModule
    {
        public void Dispose()
        {

        }

        public void Init(HttpApplication application)
        {

            application.BeginRequest += application_BeginRequest;

        }

        protected virtual void application_BeginRequest(object sender, EventArgs e)
        {
            var app = sender as HttpApplication;

            if (app == null) return;
            var requestUrl = app.Request.Url.Segments.Last();

            if (!string.IsNullOrEmpty(requestUrl) && requestUrl.Equals("health"))
            {
                app.Context.RemapHandler(new HealthCheckHandler());
            }
        }
    }
}
