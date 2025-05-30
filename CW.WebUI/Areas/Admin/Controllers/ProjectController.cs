using CW.EntitiesLayer.DataModels;
using CW.EntitiesLayer.Parametres;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace CW.WebUI.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ProjectController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public async Task<IActionResult> List(ProjectParametres filter)
        {
            using (HttpClient client = new HttpClient())
            {
                string url = "https://localhost:2025/api/Project/GetProjectList"; // API den gelen url olacak
                string jwtToken = Request.Headers["Authorization"].ToString(); //local storageden jwt bilgisi

                url = url + Request.QueryString.Value;

                client.DefaultRequestHeaders.Add("Authorization", jwtToken);

                var response = await client.GetAsync(url);
                List<ProjectDataModel> dataModels = new List<ProjectDataModel>();

                if (response.IsSuccessStatusCode)
                {
                    var jsonString = await response.Content.ReadAsStringAsync();

                    dataModels = JsonConvert.DeserializeObject<List<ProjectDataModel>>(jsonString);

                }
                return PartialView(dataModels); // partialview yazılacak
            }

        }
    }
}
