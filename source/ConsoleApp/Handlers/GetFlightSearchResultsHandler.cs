using MediatR;
using System;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApp.Handlers
{
    class GetFlightSearchResultsHandler : IRequestHandler<GetFlightSearchResults, GetFlightSearchResultsResponse>
    {
        public Task<GetFlightSearchResultsResponse> Handle(GetFlightSearchResults request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
