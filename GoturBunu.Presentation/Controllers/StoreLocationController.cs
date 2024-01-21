using MediatR;
using Microsoft.AspNetCore.Mvc;
using GoturBunu.Presentation.Abstraction;
using Microsoft.AspNetCore.Authorization;
using GoturBunu.Application.Features.Store;

namespace GoturBunu.Presentation.Controller
{
    public class StoreLocationController : ApiController
    {
        public StoreLocationController(IMediator mediator) : base(mediator) { }

        [HttpGet]
        [Authorize(nameof(GetLocationListQueryPermission))]
        public async Task<GetLocationListQueryResponse> Get([FromQuery] GetLocationListQuery query) => await _mediator.Send(query);
    }
}
