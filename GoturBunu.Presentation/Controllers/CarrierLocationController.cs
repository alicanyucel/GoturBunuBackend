using MediatR;
using Microsoft.AspNetCore.Mvc;
using GoturBunu.Application.Features.Carrier;
using GoturBunu.Presentation.Abstraction;
using Microsoft.AspNetCore.Authorization;

namespace GoturBunu.Presentation.Controller
{
    public class CarrierLocationController : ApiController
    {
        public CarrierLocationController(IMediator mediator) : base(mediator) { }

        [HttpPost]
        [Authorize(nameof(SetCurrentLocationCommandPermission))]
        public async Task<SetCurrentLocationCommandResponse> Post(SetCurrentLocationCommand command) => await _mediator.Send(command);

        [HttpGet]
        [Authorize(nameof(GetCurrentLocationListQueryPermission))]
        public async Task<GetCurrentLocationListQueryResponse> Get([FromQuery] GetCurrentLocationListQuery query) => await _mediator.Send(query);
    }
}
