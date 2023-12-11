using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace selfHostServer.Host
{
    public class productsController:ApiController
    {
        Product[] products=new Product[]
        {
            new Product{ Id=1,Name="Apple",Category="Fruits",Price=12m},
            new Product{ Id=2,Name="IPhone15",Category="Mobile",Price=1000M},
            new Product{ Id=3,Name="MacBook M3",Category="LapTop",Price=2000m}
        };
        [HttpGet]
        public IEnumerable<Product> AllProduct()
        { return products; }
    }
}
