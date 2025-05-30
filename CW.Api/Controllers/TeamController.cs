using CW.EntitiesLayer.DataModels;
using CW.EntitiesLayer.Parametres;
using CW.InterfaceLayer.IBusiness;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CW.Api.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class TeamController : BaseApiController
    {
        private readonly ITeam _iTeamBl;

        public TeamController(ITeam ITeam)
        {
            _iTeamBl = ITeam;
        }

        [HttpGet]
        [Authorize]
        public async Task<IActionResult> GetTeamList()
        {
            var result = _iTeamBl.GetTeamList();
            return Ok(result);
        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> GetTeamListPublic()
        {

            var result = _iTeamBl.GetTeamList();

            var activeMembers = result.Where(t => t.IsActive).ToList();

            return Ok(activeMembers);
        }


        [HttpDelete]
        [Authorize]
        public async Task<IActionResult> DeleteTeam([FromBody] TeamDeleteParametres param)
        {
            return Ok(_iTeamBl.DeleteTeam(param.pId));
        }


        [HttpPost]
        [Authorize]
        public async Task<IActionResult> SaveTeam([FromBody] TeamDataModel pModel)
        {
            pModel.CreatedBy = GetCurrentUserInfo(HttpContext).UserId;

            return Ok(_iTeamBl.SaveTeam(pModel));
        }


    }
}
