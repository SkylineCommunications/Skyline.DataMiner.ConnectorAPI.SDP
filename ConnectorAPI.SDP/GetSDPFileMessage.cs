using System;

using Skyline.DataMiner.Core.InterAppCalls.Common.CallSingle;

public class GetSDPFileMessage : Message
{
	public Guid SenderId { get; set; }
}