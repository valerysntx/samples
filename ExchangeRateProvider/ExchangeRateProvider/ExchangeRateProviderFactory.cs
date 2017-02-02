using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExchangeRateProvider.DependencyInjection;
using ExchangeRateProvider.Infrastructure.ApiProxy;
using ExchangeRateProvider.Infrastructure.HttpHelper;
using Microsoft.Practices.ServiceLocation;
using StructureMap;
using StructureMap.Graph;

namespace ExchangeRateProvider
{
    public class ExchangeRateProviderFactory : IExchangeRateProviderFactory, IDisposable
    {
        static ExchangeRateProviderFactory()
        {
           container = new Container();
           container.Configure(cfg =>
           {
               cfg.For<IHttpHelper>().Use(x => new HttpHelperAsync()).ContainerScoped();
               cfg.For<ApiProxy>().Use<CurrencyApiProxy>()
                   .Ctor<CurrencyApiProxy>()
                   .IsTheDefault()
                   .ContainerScoped();

               cfg.For<IExchangeRateProvider>().Use(x=> new NordicBankExchangeRateProvider(null)).ContainerScoped();
               cfg.For<AbstractExchangeRateProvider>().Use(x=> new NordicBankExchangeRateProvider(null)).ContainerScoped();

               cfg.Scan(scanner => scanner.AssembliesAndExecutablesFromApplicationBaseDirectory());
           });

            ServiceLocator.SetLocatorProvider(() => new StructureMapServiceLocator(container));
        }

        private static IContainer container { get; }

        public IExchangeRateProvider GetExchangeRateProvider()
        {
            return ServiceLocator.Current.GetInstance<IExchangeRateProvider>();
        }

        public void Dispose()
        {
            container?.Dispose();
        }
    }
}
