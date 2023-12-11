using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace selfHostServer.Host
{
    public class OrdersController:ApiController
    {
        order[] orders =new order[]
        {
            new order{Id=1,Name="Tomato",Category="Geroceris",Price=1},
            new order{Id=2,Name="Yoo-yo",Category="Toys",Price=2.34m},
            new order{Id=3,Name="Hummer",Category="Hardware",Price=3.4m}
        };
        public IEnumerable<order> GetOrders()
        {
            return orders;
        }
        
    }

  
   
}
