using CW.EntitiesLayer.DataModels;
using CW.EntitiesLayer.Parametres;
using CW.InterfaceLayer.IBusiness;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CW.Api.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class HomeController : BaseApiController
    {

        private readonly IHome _iHomeBl;

        public HomeController(IHome IHome)
        {
            _iHomeBl = IHome;
        }

        // genel kullanıcı verisi
        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> GetHomePageListPublic()
        {
            var result = _iHomeBl.GetHomePageList();
            return Ok(result);
        }

        //admin verisi
        [HttpGet]
        [Authorize]
        public async Task<IActionResult> GetHomePageList()
        {
            var result = _iHomeBl.GetHomePageList();
            return Ok(result);
        }

        [HttpDelete]
        [Authorize]
        public async Task<IActionResult> DeleteHomePage([FromBody] HomeDeleteParametres param)
        {
            return Ok(_iHomeBl.DeleteHomePage(param.pId));
        }

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> SaveHomePage([FromBody] HomeDataModel pModel)
        {
            pModel.CreatedBy = GetCurrentUserInfo(HttpContext).UserId;

            return Ok(_iHomeBl.SaveHomePage(pModel));
        }

    }
}
