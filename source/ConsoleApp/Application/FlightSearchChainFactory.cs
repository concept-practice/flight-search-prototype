using ConsoleApp.ChainOfResponsibility;
using ConsoleApp.Handlers;

namespace ConsoleApp.Application
{
    public class FlightSearchChainFactory : IChainFactory<FlightSearchChainCommand>
    {
        public IChainHandler<FlightSearchChainCommand> CreateChain()
        {
            throw new System.NotImplementedException();
        }
    }
}
