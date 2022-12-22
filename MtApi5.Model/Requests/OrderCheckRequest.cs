namespace MtApi5.Requests
{
    public class OrderCheckRequest: RequestBase
    {
        public override RequestType RequestType => RequestType.OrderCheck;

        public MqlTradeRequest TradeRequest { get; set; }

    }
}