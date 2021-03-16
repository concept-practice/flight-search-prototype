using MediatR;

namespace ConsoleApp.Handlers
{
    public class GetFlightSearchResults : IRequest<GetFlightSearchResultsResponse>
    {
        public string Departure { get; set; }

        public string Arrival { get; set; }
    }
}
