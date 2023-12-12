using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;
using System.Web.Http.SelfHost;
namespace selfHostServer.Host
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var config = new HttpSelfHostConfiguration("http://localhost:5009");
            config.Routes.MapHttpRoute("Api Default","api/{controller}/{id}", new { id = RouteParameter.Optional });
            using(HttpSelfHostServer server = new HttpSelfHostServer(config))
            {
                server.OpenAsync().Wait();
                Console.Read();      //Just for waiting
            }
        }
    }
}