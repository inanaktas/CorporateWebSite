using CW.EntitiesLayer.DataModels;
using CW.EntitiesLayer.ViewModels;
using CW.InterfaceLayer.IBusiness;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CW.Api.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class AboutUsController : BaseApiController
    {

        private readonly IAboutUs _iAboutUsBl;
        public AboutUsController(IAboutUs IAboutUs)
        {
            _iAboutUsBl = IAboutUs;
        }

        // Genel Kullanıcı sayfası için alınan veri
        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> GetAboutUsPublic()
        {
            return Ok(_iAboutUsBl.GetAboutUsDataModel());
        }

        //Admin sayfası için alınan veri.İkiside aynı işi yapmasına rağmen ayrı olarak tutuldu.BL kısmıda ayrılabilir mi?
        [HttpGet]
        [Authorize]
        public async Task<IActionResult> GetAboutUs()
        {
            return Ok(_iAboutUsBl.GetAboutUsDataModel());
        }

        //Admin sayfası kayıt işlemi
        [HttpPost]
        [Authorize]
        public async Task<IActionResult> SaveAboutUs([FromBody] AboutUsDataModel model)
        {
            model.CreatedBy = GetCurrentUserInfo(HttpContext).UserId;


            // Kayıt sonucu dönen bilgi mesajı için
            ResponseResultViewModel<int> result = new ResponseResultViewModel<int>();

            try
            {
                result.Result = _iAboutUsBl.SaveAboutUs(model);
                result.Message = "Hakkımızda kayıt edildi.";
                result.IsSuccess = true;
            }
            catch (Exception ex)
            {
                result.ErrorMessage = ex.Message;
                result.IsSuccess = false;
                result.Message = "Hata alındı";
            }

            return Ok(result);
        }
    }
}
