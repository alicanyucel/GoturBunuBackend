using MediatR;
using Microsoft.AspNetCore.Mvc;
using GoturBunu.Presentation.Abstraction;
using GoturBunu.Application.Features.Store;

namespace GoturBunu.Presentation.Controller
{
    public class StoreRegistryRequestController : ApiController
    {
        public StoreRegistryRequestController(IMediator mediator) : base(mediator)
        { }

        [HttpGet]
        public async Task<GetRegistryRequestListQueryResponse> Get([FromQuery] GetRegistryRequestListQuery query) => await _mediator.Send(query);
        
        [HttpPost]
        public async Task<CreateRegistryRequestCommandResponse> Post(CreateRegistryRequestCommand command) => await _mediator.Send(command);
    }
}
