using System.Threading.Tasks;

namespace ConsoleApp.ChainOfResponsibility
{
    public interface IChainHandler<T>
    {
        Task<T> Handle(T request);
    }
}
