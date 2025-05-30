using CW.EntitiesLayer.DataModels;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using System.Net.Http.Headers;

namespace CW.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class TeamController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> List()
        {
            using (HttpClient client = new HttpClient())
            {
                string url = "https://localhost:2025/api/Team/GetTeamList"; // API'nin URL'i (parametresiz)

                // JWT Token'ı header'a ekle
                string jwtToken = Request.Headers["Authorization"].ToString();
                client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", jwtToken.Replace("Bearer ", ""));


                // API'ye GET isteği gönder
                var response = await client.GetAsync(url);

                List<TeamDataModel> dataModels = new List<TeamDataModel>();

                // Eğer API'den başarılı bir cevap alındıysa
                if (response.IsSuccessStatusCode)
                {
                    var jsonString = await response.Content.ReadAsStringAsync();

                    // JSON string'i, TeamDataModel listesine deserialize et
                    dataModels = JsonConvert.DeserializeObject<List<TeamDataModel>>(jsonString);
                }

                // Verileri PartialView'e gönder
                return PartialView(dataModels);
            }
        }
    }
}
