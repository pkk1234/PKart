using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;

namespace QuickKartMVCApp.Repository
{
    public class ServiceRepository
    {
        private HttpClient Client { get; set; }
        public ServiceRepository(IConfiguration Configuration)
        {
            Client = new HttpClient();
            Client.BaseAddress = new Uri(Configuration.GetSection("ServiceUrl").Value.ToString());
        }
        public HttpResponseMessage GetResponse(string url)
        {
            return Client.GetAsync(url).Result;
        }
    }

}
