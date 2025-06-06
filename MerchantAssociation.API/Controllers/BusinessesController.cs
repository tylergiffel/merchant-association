using Microsoft.AspNetCore.Mvc;
using MediatR;
using MerchantAssociation.API.Features.Businesses.Commands;
using System.Threading.Tasks;

namespace MerchantAssociation.API.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BusinessesController : ControllerBase
    {
        private readonly IMediator _mediator;

        public BusinessesController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpPost]
        public async Task<ActionResult<int>> Create(CreateBusiness command)
        {
            var businessId = await _mediator.Send(command);
            return Ok(businessId);
        }
    }
}