using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

using Newtonsoft.Json;

using esun.Models;
using esun.Data;

namespace esun.Controllers
{
    public class HomeController : Controller
    {
        public async Task<ActionResult> Index()
        {
            return View();
        }


        public async Task<List<BRIDGE>> GetData(string path)
        {
            List<BRIDGE> bridges = null;
            using (HttpClient client = new HttpClient())
            {
                client.Timeout = TimeSpan.FromSeconds(20);
                HttpResponseMessage response = await client.GetAsync(path);
                response.EnsureSuccessStatusCode();
                string responseBody = await response.Content.ReadAsStringAsync();
                responseBody = responseBody.Replace("\r\n", string.Empty);
                bridges = JsonConvert.DeserializeObject<List<BRIDGE>>(responseBody);

            }
            return bridges;
        }

    }
}