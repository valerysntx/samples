using System;
using System.Collections.Generic;
using System.Linq;
using ExchangeRateProvider.Model;

namespace ExchangeRateProvider
{
    /// <summary>
    /// NordicBankExchangeRateProvider
    /// </summary>
    public class NordicBankExchangeRateProvider : AbstractExchangeRateProvider
    {
        public NordicBankExchangeRateProvider(string apiUrl) : base(apiUrl)
        {
        }

        public override IEnumerable<ExchangeRateDto> GetExchangeRates(IEnumerable<CurrencyDto> currencies)
        {

            var exchangeRates = Currency.GetExchangeRatesAsync()?.Result;
            if (exchangeRates != null)
            {
                if (currencies == null) return exchangeRates.ToList();

                var codes = currencies.Select(c => c.Code);
                return exchangeRates.Where(x => codes.Contains(x.SourceCurrency.Code, EqualityComparer<string>.Default)).ToList();
            }
            throw new InvalidOperationException();
        }
    }
}