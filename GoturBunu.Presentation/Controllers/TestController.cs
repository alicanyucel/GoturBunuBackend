using MediatR;
using Microsoft.AspNetCore.Mvc;
using GoturBunu.Application.Features.Test;
using GoturBunu.Presentation.Abstraction;
using Microsoft.AspNetCore.Authorization;
using GoturBunu.Application.Features.Offer;

namespace GoturBunu.Presentation.Controller
{
    public class TestController : ApiController
    {
        public TestController(IMediator mediator) : base(mediator) { }

        [HttpGet]
        [Authorize(nameof(GetTestDataListQueryPermission))]
        public async Task<GetTestDataListQueryResponse> Get([FromQuery] GetTestDataListQuery query) => await _mediator.Send(query);

        [HttpPost]
        public async Task<CreateTestCommandResponse> Post(CreateTestCommand command) => await _mediator.Send(command);

        [HttpPost("SendOfferTo")]
        public async Task<SendOfferToCommandResponse> Post(SendOfferToCommand command) => await _mediator.Send(command);
    }
}
