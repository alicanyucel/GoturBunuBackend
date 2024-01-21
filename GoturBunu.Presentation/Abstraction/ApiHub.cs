using MediatR;
using Microsoft.AspNetCore.SignalR;

namespace GoturBunu.Presentation.Abstraction
{
    public abstract class ApiHub : Hub
    {
        protected readonly IMediator _mediator;
        protected ApiHub(IMediator mediator)
        {
            _mediator = mediator;
        }
    }
}