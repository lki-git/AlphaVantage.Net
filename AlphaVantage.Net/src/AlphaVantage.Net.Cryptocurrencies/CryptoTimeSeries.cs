using System.Collections.Generic;
using AlphaVantage.Net.Common.Currencies;
using AlphaVantage.Net.Common.Intervals;

namespace AlphaVantage.Net.Cryptocurrencies
{
    public class CryptoTimeSeries
    {
        public Interval Interval { get; set; }
        
        public DigitalCurrency FromSymbol { get; set; }
        
        public PhysicalCurrency ToSymbol { get; set; }
        
        public ICollection<CryptoDataPoint> DataPoints {get; set;} = new List<CryptoDataPoint>();
        
        public Dictionary<string, string> MetaData { get; set; } = new Dictionary<string, string>();
    }
}