namespace Skyline.DataMiner.ConnectorAPI.SDP
{
    using System;

    using Skyline.DataMiner.Core.InterAppCalls.Common.CallSingle;

public class SetSDPConfigurationMessage : Message
{
    public Guid Id { get; set; }

    public string SDPFileContent { get; set; }

    public DateTime Timestamp { get; set; }
}
