namespace ExchangeRateProvider
{
    public interface IExchangeRateProviderFactory
    {
        IExchangeRateProvider GetExchangeRateProvider();
    }
}

