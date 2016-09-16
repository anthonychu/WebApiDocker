using System.Collections.Generic;
using System.Web.Http;

namespace WebApiDocker
{
    public class ValuesController : ApiController
    {
        public IEnumerable<string> Get()
        {
            return new List<string> { "ASP.NET", "Docker", "Windows Server Containers" };
        }
    }
}
