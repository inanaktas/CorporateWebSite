using CW.BusinessLayer;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CW.Api.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class LookUpController : ControllerBase
    {
        LookUpBL bl = new LookUpBL();

        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> GetSkills()
        {
            return Ok(bl.GetSkills());
        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> GetExperiences()
        {
            return Ok(bl.GetExperiences());
        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> GetJobCategories()
        {
            return Ok(bl.GetJobCategories());
        }

    }
}
