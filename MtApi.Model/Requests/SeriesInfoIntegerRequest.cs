namespace MtApi.Requests
{
    public class SeriesInfoIntegerRequest: RequestBase
    {
        public override RequestType RequestType => RequestType.SeriesInfoInteger;

        public string SymbolName { get; set; }
        public int Timeframe { get; set; }
        public int PropId { get; set; }
    }
}
