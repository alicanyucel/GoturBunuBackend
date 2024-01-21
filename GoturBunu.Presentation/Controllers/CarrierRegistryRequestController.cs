using MediatR;
using Microsoft.AspNetCore.Mvc;
using GoturBunu.Presentation.Abstraction;
using GoturBunu.Application.Features.Carrier;

namespace GoturBunu.Presentation.Controller
{
    public class CarrierRegistryRequestController : ApiController
    {
        public CarrierRegistryRequestController(IMediator mediator) : base(mediator)
        { }

        [HttpGet]
        public async Task<GetRegistryRequestListQueryResponse> Get([FromQuery] GetRegistryRequestListQuery query) => await _mediator.Send(query);

        [HttpPost]
        public async Task<CreateRegistryRequestCommandResponse> Post(CreateRegistryRequestCommand command) => await _mediator.Send(command);
    }
}
