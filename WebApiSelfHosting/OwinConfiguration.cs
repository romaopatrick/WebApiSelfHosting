using Owin;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace WebApiSelfHosting
{
    public class OwinConfiguration
    {
        public void Configuration(IAppBuilder app)
        {
            app.UseWebApi(WebApiConfig.Register());
        }
    }
}
