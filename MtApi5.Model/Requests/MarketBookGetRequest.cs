namespace MtApi5.Requests
{
    public class MarketBookGetRequest: RequestBase
    {
        public override RequestType RequestType => RequestType.MarketBookGet;

        public string Symbol { get; set; }
    }
}