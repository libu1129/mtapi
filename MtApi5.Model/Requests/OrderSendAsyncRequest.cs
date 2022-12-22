namespace MtApi5.Requests
{
    public class OrderSendAsyncRequest : RequestBase
    {
        public override RequestType RequestType => RequestType.OrderSendAsync;

        public MqlTradeRequest TradeRequest { get; set; }
    }
}