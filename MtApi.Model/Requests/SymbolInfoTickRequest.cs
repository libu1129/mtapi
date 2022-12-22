namespace MtApi.Requests
{
    public class SymbolInfoTickRequest: RequestBase
    {
        public override RequestType RequestType => RequestType.SymbolInfoTick;

        public string Symbol { get; set; }
    }
}