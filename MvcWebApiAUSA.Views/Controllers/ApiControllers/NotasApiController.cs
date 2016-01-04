using Microsoft.Practices.Unity;
using MvcWebApiAUSA.BusinessServices.IService;
using MvcWebApiAUSA.BusinessServices.Services;
using System.Collections.Generic;
using System.Web.Http;
using System.Web.Mvc;

namespace MvcWebApiAUSA.Views.Controllers
{
    public class NotasApiController : ApiController
    {
        private INotasServices service;

        public NotasApiController()
        {
            service = Unity.Bootstrapper.Container.Resolve<NotasServices>();
        }

        // GET api/Notas
        public IEnumerable<string> GetNotas()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/Notas/5
        public string GetNotasById(int id)
        {
            return "value";
        }

        // POST api/Notas
        public void PostNotas(string id, string not_str_archivo)
        {
            service.ReadNotaUrl(id, not_str_archivo);
        }

        // PUT api/Notas/5
        public void PutNotas(string id, string not_str_archivo)
        {
           service.ReadNotaUrl(id, not_str_archivo);
        }

        // DELETE api/Notas/5
        public void DeleteNotas(int id)
        {
        }
    }
}
