using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.Owin;
using Owin;
using MvcWebApiAUSA.Views.Controllers;
using Microsoft.Practices.Unity;
using MvcWebApiAUSA.Views.Areas.HelpPage.Controllers;

[assembly: OwinStartup(typeof(MvcWebApiAUSA.Views.Startup))]

namespace MvcWebApiAUSA.Views
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
            Unity.Bootstrapper.Initialise();
        }
    }
}
