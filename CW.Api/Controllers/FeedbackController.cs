using CW.EntitiesLayer.DataModels;
using CW.EntitiesLayer.Parametres;
using CW.InterfaceLayer.IBusiness;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CW.Api.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class FeedbackController : ControllerBase
    {
        private readonly IFeedback _iFeedbackBL;
        public FeedbackController(IFeedback IFeedback)
        {
            _iFeedbackBL = IFeedback;
        }

        [HttpGet]
        [Authorize]
        public async Task<IActionResult> GetAllFeedbacks()
        {
            return Ok(_iFeedbackBL.GetAllFeedbacks());
        }

        [HttpPost]
        [AllowAnonymous]
        public async Task<IActionResult> Save([FromBody] FeedbackDataModel pModel)
        {
            return Ok(_iFeedbackBL.SaveFeedback(pModel));
        }

        [HttpDelete]
        [Authorize]
        public async Task<IActionResult> DeleteFeedback([FromBody] FeedbackDeleteParametres param)
        {
            return Ok(_iFeedbackBL.DeleteFeedback(param.pId));
        }

        [HttpPost]
        [Authorize]
        public async Task<IActionResult> UpdateFeedback([FromBody] FeedbackUpdateDataModel pModel)
        {
            return Ok(_iFeedbackBL.UpdateFeedback(pModel));
        }

    }
}
