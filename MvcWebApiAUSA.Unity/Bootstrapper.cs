using Microsoft.Practices.Unity;
using MvcWebApiAUSA.BusinessServices.IService;
using MvcWebApiAUSA.BusinessServices.Services;
using MvcWebApiAUSA.DataModel.DALs;
using MvcWebApiAUSA.DataModel.IDALs;
using System.Web.Mvc;
using Unity.Mvc3;

namespace MvcWebApiAUSA.Unity
{
    public static class Bootstrapper
    {
        public static IUnityContainer Container { get; set; }

        public static void Initialise()
        {
            var container = BuildUnityContainer();

            DependencyResolver.SetResolver(new UnityDependencyResolver(container));

            Container = container;
        }

        private static IUnityContainer BuildUnityContainer()
        {
            var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers

            // e.g. container.RegisterType<ITestService, TestService>(); 
            container.RegisterType<INotasDAL, NotasDAL>();
            container.RegisterType<INotasServices, NotasServices>();
            return container;
        }
    }
}