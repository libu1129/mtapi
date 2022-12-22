using System;

namespace MtApi.Requests
{
    public class SymbolInfoDoubleRequest : RequestBase
    {
        public override RequestType RequestType => RequestType.SymbolInfoDouble;

        public string SymbolName { get; set; }
        public int PropId { get; set; }
    }
}