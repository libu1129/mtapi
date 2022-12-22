namespace MtApi5.Events
{
    public class OnTradeTransactionEvent
    {
        public MqlTradeTransaction Trans { get; set; }
        public MqlTradeRequest Request { get; set; }
        public MqlTradeResult Result { get; set; }
    }
}