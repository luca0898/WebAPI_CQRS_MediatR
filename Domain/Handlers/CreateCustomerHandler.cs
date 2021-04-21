using System;
using System.Threading;
using System.Threading.Tasks;
using MediatR;
using Shop.Domain.Commands.Requests;
using Shop.Domain.Commands.Responses;

namespace Shop.Domain.Handlers
{
    public class CreateCustomerHandler : IRequestHandler<CreateCustomerRequest, CreateCustomerResponse>
    {
        public Task<CreateCustomerResponse> Handle(CreateCustomerRequest request, CancellationToken cancellationToken)
        {
            CreateCustomerResponse customer = new CreateCustomerResponse
            {
                Id = Guid.NewGuid(),
                Name = request.Name,
                Email = request.Email,
                Date = DateTime.Now
            };

            return Task.FromResult(customer);
        }
    }
}