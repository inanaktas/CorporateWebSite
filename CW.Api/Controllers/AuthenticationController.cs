using CW.EntitiesLayer.DataModels;
using CW.EntitiesLayer.Parametres;
using CW.EntitiesLayer.ViewModels;
using CW.InterfaceLayer.IBusiness;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CW.Api.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class AuthenticationController : BaseApiController
    {

        private readonly IUserInfo _iUserInfoBl;
        public AuthenticationController(IUserInfo IUserInfo)
        {
            _iUserInfoBl = IUserInfo;
        }

        [HttpPost]
        public async Task<IActionResult> SignIn([FromBody] SignInParametres pUserInfo)
        {

            UserInfoDataModel model = _iUserInfoBl.CheckUserBL(pUserInfo);

            ResponseResultViewModel<UserInfoDataModel> response = new ResponseResultViewModel<UserInfoDataModel>();

            if (model == null)
            {
                response.IsSuccess = false;
                response.Message = "Kullanıcı adı ve şifre bulunamadı.";
            }

            else
            {
                response.IsSuccess = true;
                response.Message = GenerateJwtToken(model);
                response.Result = model;
            }

            return Ok(response);
        }

        [Authorize]
        [HttpPost]
        public async Task<IActionResult> CheckSession()
        {
            return Ok(GetCurrentUserInfo(HttpContext));
        }



    }
}


