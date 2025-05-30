using CW.EntitiesLayer.DataModels;
using CW.EntitiesLayer.Parametres;
using CW.InterfaceLayer.IBusiness;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CW.Api.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ProjectController : BaseApiController
    {
        private readonly IProject _iProjectBl;
        public ProjectController(IProject IProject)
        {
            _iProjectBl = IProject;
        }

        //admin için veriler
        [HttpGet]
        [Authorize]
        public async Task<IActionResult> GetProjectList([FromQuery] ProjectParametres filter)
        {

            //var result = await _iProjectBl.GetProjectList(filter);

            return Ok(_iProjectBl.GetProjectList(filter));
        }

        //genel kullanıcı için veriler
        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> GetPublicProjectList([FromQuery] ProjectParametres filter)
        {
            return Ok(_iProjectBl.GetProjectList(filter));
        }

        [HttpDelete]
        [Authorize]
        public async Task<IActionResult> DeleteProject([FromBody] ProjectDeleteParametres param)
        {
            return Ok(_iProjectBl.DeleteProject(param.pId));
        }

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> Save([FromBody] ProjectDataModel pModel)
        {
            pModel.CreatedBy = GetCurrentUserInfo(HttpContext).UserId;
            return Ok(_iProjectBl.SaveProject(pModel));
        }
    }
}
