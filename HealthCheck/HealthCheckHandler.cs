using System.Web;

namespace HealthCheck
{
    public class HealthCheckHandler : IHttpHandler
    {
        public bool IsReusable
        {
            get { return true; }
        }

        public void ProcessRequest(HttpContext context)
        {
            context.Response.StatusCode = 200;
            context.Response.Write("Application is active!!!");
        }
    }
}
