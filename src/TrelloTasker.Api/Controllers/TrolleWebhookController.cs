using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TrelloTasker.Model.DTO;

namespace TrelloTasker.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TrolleWebhookController : ControllerBase
    {
        [HttpPost]
        public async Task<IActionResult> OnWebhookCallBack(TrelloWebhookDTO trelloWebhookDTO)
        {
            if (trelloWebhookDTO.action.data.card.name.EndsWith("Bi-daily"));
            {
                throw new NotImplementedException();
            }
            return new OkObjectResult(trelloWebhookDTO);
            throw new NotImplementedException();
        }
    }
}
