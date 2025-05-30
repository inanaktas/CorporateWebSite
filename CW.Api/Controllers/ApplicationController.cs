using CW.EntitiesLayer.DataModels;
using CW.EntitiesLayer.Parametres;
using CW.InterfaceLayer.IBusiness;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CW.Api.Controllers
{
	[Route("api/[controller]/[action]")]
	[ApiController]
	public class ApplicationController : ControllerBase
	{
		private readonly IApplication _iApplicationBL;

		public ApplicationController(IApplication IApplication)
		{
			_iApplicationBL = IApplication;

		}

		[HttpGet]
		[Authorize]
		public async Task<IActionResult> GetAllApplications()
		{
			return Ok(_iApplicationBL.GetAllApplications());
		}

		//kullanıcının iş başvurusunu kayıt etmesi adına authorize değil
		[HttpPost]
		[AllowAnonymous]
		public async Task<IActionResult> Save([FromBody] ApplicationDataModel pModel)
		{
			return Ok(_iApplicationBL.SaveApplication(pModel));

		}

		[HttpDelete]
		[Authorize]
		public async Task<IActionResult> DeleteApplication([FromBody] ApplicationDeleteParametres param)
		{
			return Ok(_iApplicationBL.DeleteApplication(param.pId));
		}
	}
}
