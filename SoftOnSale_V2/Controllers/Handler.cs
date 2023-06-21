using ServiceStack.Host;
using System.Web;

namespace SoftOnSale_V2.Controllers
{
    public class Handler : IHttpHandler
    {
		public void ProcessRequest(HttpContext context)
        {
            context.Response.ContentType = "text/plain";
            context.Response.WriteAsync("____________________________________");
            
        }
        public bool IsReusable
        {
            get
            {
                return true;
            }
        }
    }
}
