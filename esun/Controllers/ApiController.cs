using System;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Net.Http;
using System.Threading.Tasks;
using System.Collections.Generic;

using Newtonsoft.Json;

using esun.Models;
using esun.Data;

namespace esun.Controllers
{
    public class ApiController : Controller
    {
        // GET: Api
        private string apiUrl = "https://tpnco.blob.core.windows.net/blobfs/Bridges.json";

        private esunContext db = new esunContext();

        public async Task<ActionResult> GetApiData()
        {
            using (HttpClient client = new HttpClient())
            {
                try
                {
                    client.Timeout = TimeSpan.FromSeconds(20);
                    HttpResponseMessage response = await client.GetAsync(apiUrl);
                    response.EnsureSuccessStatusCode();
                    string responseBody = await response.Content.ReadAsStringAsync();
                    responseBody = responseBody.Replace("\r\n", string.Empty);
                    var bridges = JsonConvert.DeserializeObject<List<BRIDGE>>(responseBody);

                    return Json(
                        new { status = 0, data = bridges, message = "Success." },
                        JsonRequestBehavior.AllowGet);
                }
                catch (Exception e)
                {

                    return Json(
                        new { status = 1, message = e.Message },
                        JsonRequestBehavior.AllowGet);
                }
            }
        }


        public void Create(List<BRIDGE> cData)
        {
            try
            {
                // 新增 BRIDGE 資料
                db.BRIDGE.AddRange(cData);
                db.SaveChanges();
            }
            catch (Exception e)
            {
                // 若發生錯誤，將訊息存至ViewBag，在View顯示
                ViewBag.Message = e.InnerException.Message;
            }
        }
    }
}