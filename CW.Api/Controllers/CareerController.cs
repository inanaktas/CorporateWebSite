using CW.EntitiesLayer.DataModels;
using CW.EntitiesLayer.Parametres;
using CW.InterfaceLayer.IBusiness;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CW.Api.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class CareerController : BaseApiController
    {

        private readonly ICareer _iCareerBl;

        public CareerController(ICareer ICareer)
        {
            _iCareerBl = ICareer;
        }

        // kullanıcı sayfası kariyer sekmesi bilgilerini getiren metot
        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> GetCareerListPublic()
        {
            return Ok(_iCareerBl.GetCareerList());
        }

        // admin sayfası kariyer düzenleme sekmesi bilgilerini getiren metot
        [HttpGet]
        [Authorize]
        public async Task<IActionResult> GetCareerList()
        {
            return Ok(_iCareerBl.GetCareerList());
        }

        [HttpDelete]
        [Authorize]
        public async Task<IActionResult> DeleteCareer([FromBody] CareerDeleteParametres param)
        {
            return Ok(_iCareerBl.DeleteCareer(param.pId));
        }

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> SaveCareer([FromBody] CareerDataModel pModel)
        {
            pModel.CreatedBy = GetCurrentUserInfo(HttpContext).UserId;

            return Ok(_iCareerBl.SaveCareer(pModel));
        }

    }
}
