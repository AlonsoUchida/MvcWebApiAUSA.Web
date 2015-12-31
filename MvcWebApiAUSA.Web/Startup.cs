using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Owin;
using Owin;

[assembly: OwinStartup(typeof(MvcWebApiAUSA.Web.Startup))]

namespace MvcWebApiAUSA.Web
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            Unity.Bootstrapper.Initialise();
            ConfigureAuth(app);
        }
    }
}
