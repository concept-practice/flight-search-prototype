using ConsoleApp.ChainOfResponsibility;
using ConsoleApp.Handlers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp.Application
{
    public class FindAllDepartureChainHandler : IChainHandler<FlightSearchChainCommand>
    {
        public Task<FlightSearchChainCommand> Handle(FlightSearchChainCommand request)
        {
            throw new NotImplementedException();
        }
    }
}
