
using CW.EntitiesLayer.DataModels;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace CW.WebUI.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }


        //Tüm controller tek klasörde tutuldu. Ayrý ayrý tutulmasýnda daha saðlýklý mý?

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult AboutUs()
        {
            return View();
        }

        public IActionResult Project()
        {
            return View();

        }

        public IActionResult Team()
        {
            return View();
        }

        public IActionResult Career()
        {
            return View();
        }

        public IActionResult Application()
        {
            return View();
        }



        public async Task<IActionResult> List()
        {
            using (HttpClient client = new HttpClient())
            {
                string url = "https://localhost:2025/api/Project/GetPublicProjectList";
                var response = await client.GetAsync(url);
                List<ProjectDataModel> dataModels = new List<ProjectDataModel>();

                if (response.IsSuccessStatusCode)
                {
                    var jsonString = await response.Content.ReadAsStringAsync();
                    dataModels = JsonConvert.DeserializeObject<List<ProjectDataModel>>(jsonString);
                }

                return PartialView("List", dataModels);

            }

        }

        public async Task<IActionResult> HomePageList()
        {
            using (HttpClient client = new HttpClient())
            {
                string url = "https://localhost:2025/api/Home/GetHomePageListPublic";
                var response = await client.GetAsync(url);
                List<HomeDataModel> dataModels = new List<HomeDataModel>();

                if (response.IsSuccessStatusCode)
                {
                    var jsonString = await response.Content.ReadAsStringAsync();
                    dataModels = JsonConvert.DeserializeObject<List<HomeDataModel>>(jsonString);
                }

                return PartialView("HomePageList", dataModels);

            }

        }

        public async Task<IActionResult> TeamList()
        {
            using (HttpClient client = new HttpClient())
            {
                string url = "https://localhost:2025/api/Team/GetTeamListPublic";
                var response = await client.GetAsync(url);
                List<TeamDataModel> dataModels = new List<TeamDataModel>();

                if (response.IsSuccessStatusCode)
                {
                    var jsonString = await response.Content.ReadAsStringAsync();
                    dataModels = JsonConvert.DeserializeObject<List<TeamDataModel>>(jsonString);
                }


                return PartialView("TeamList", dataModels);

            }

        }

        public async Task<IActionResult> CareerList()
        {
            using (HttpClient client = new HttpClient())
            {
                string url = "https://localhost:2025/api/Career/GetCareerListPublic";
                var response = await client.GetAsync(url);
                List<CareerDataModel> dataModels = new List<CareerDataModel>();

                if (response.IsSuccessStatusCode)
                {
                    var jsonString = await response.Content.ReadAsStringAsync();
                    dataModels = JsonConvert.DeserializeObject<List<CareerDataModel>>(jsonString);
                }


                return PartialView("CareerList", dataModels);

            }

        }




    }
}


