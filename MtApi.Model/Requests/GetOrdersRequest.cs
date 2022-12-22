namespace MtApi.Requests
{
    public class GetOrdersRequest: RequestBase
    {
        public int Pool { get; set; }

        public override RequestType RequestType => RequestType.GetOrders;
    }
}