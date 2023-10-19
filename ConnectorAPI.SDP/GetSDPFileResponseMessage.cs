namespace Skyline.DataMiner.ConnectorAPI.SDP
{
    using Skyline.DataMiner.Core.InterAppCalls.Common.CallSingle;

    using System;

    public class GetSDPFileResponseMessage : Message
    {
        public Guid SenderId { get; set; }

        public string SDPFileContent { get; set; }
    }
}