using Microsoft.Practices.Unity;
using MvcWebApiAUSA.BusinessServices.IService;
using MvcWebApiAUSA.BusinessServices.Services;
using System.Collections.Generic;
using System.Web.Http;
using System.Web.Mvc;

namespace MvcWebApiAUSA.Web.Controllers
{
    public class NotasController : ApiController
    {
        private INotasServices service;

        public NotasController()
        {
            service = Unity.Bootstrapper.Container.Resolve<NotasServices>();
        }

        // GET:
        public ActionResult Index()
        {
            return null;
        }

        // GET api/default1
        public IEnumerable<string> GetNotas()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/default1/5
        public string GetNotasById(int id)
        {
            return "value";
        }

        // POST api/default1
        public void PostNotas(string id, string not_str_archivo)
        {
            service.ReadNotaUrl(id, not_str_archivo);
        }

        // PUT api/default1/5
        public void PutNotas(string id, string not_str_archivo)
        {
           service.ReadNotaUrl(id, not_str_archivo);
        }

        // DELETE api/default1/5
        public void DeleteNotas(int id)
        {
        }
    }
}
