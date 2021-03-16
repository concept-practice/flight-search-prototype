namespace ConsoleApp.ChainOfResponsibility
{
    public interface IChainFactory<T>
    {
        IChainHandler<T> CreateChain();
    }
}
