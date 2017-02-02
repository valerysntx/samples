using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using AutoMapper;
using ExchangeRateProvider;
using ExchangeRateProvider.Model;

using Microsoft.Practices.ServiceLocation;


namespace ExchangeRateUpdater
{
    public class ExchangeRateProvider
    {
        /// <summary>
        /// Should return exchange rates among the specified currencies that are defined by the source.
        /// But only those defined by the source,
        ///
        /// do not return calculated exchange rates. E.g. if the source contains "EUR/USD" but not "USD/EUR",
        /// do not return exchange rate "USD/EUR" with value calculated as 1 / "EUR/USD".
        ///
        /// If the source does not provide
        /// some of the currencies, ignore them.
        /// </summary>
        public ExchangeRateProvider()
        {
            Mapper.Initialize((c) =>
            {
                c.CreateMap<CurrencyDto,Currency>();
                c.CreateMap<ExchangeRateDto,ExchangeRate>().ConstructProjectionUsing(x=> new ExchangeRate(new Currency(x.SourceCurrency.Code), new Currency(x.TargetCurrency.Code), x.Value));
                c.CreateMap<List<CurrencyDto>, List<Currency>>();
                c.CreateMap<Currency, CurrencyDto>().ConstructProjectionUsing(x => new CurrencyDto() {Code = x.Code});
                c.CreateMap<List<ExchangeRateDto>, List<ExchangeRate>>();
            });
        }


        /// <exception cref="InvalidOperationException">invalid response from ExchangeRatesProvider</exception>
        public IEnumerable<ExchangeRate> GetExchangeRates(IEnumerable<Currency> currencies)
        {
            using (var provider = new ExchangeRateProviderFactory())
            {
                List<ExchangeRateDto> rates =
                    provider.GetExchangeRateProvider()?.GetExchangeRates(Mapper.Map<IEnumerable<CurrencyDto>>(currencies)).ToList();
                if (rates == null) throw new InvalidOperationException("invalid response from ExchangeRatesProvider");

                return Mapper.Map<IEnumerable<ExchangeRate>>(rates);
            }
        }
    }
}
