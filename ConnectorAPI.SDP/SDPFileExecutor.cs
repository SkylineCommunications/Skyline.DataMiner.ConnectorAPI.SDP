namespace QAction_7
{
    using System;

    using Skyline.DataMiner.Core.InterAppCalls.Common.CallSingle;
    using Skyline.DataMiner.Core.InterAppCalls.Common.MessageExecution;

    public class SDPFileResponse : Message
	{
		public Guid SenderId { get; set; }

		public string SDPFileContent { get; set; }
	}

	public abstract class SDPFileExecutor : MessageExecutor<SDPFileMessage>
	{
		private string sdpFileContent;

		public SDPFileExecutor(SDPFileMessage message) : base(message)
		{
		}

		/// <summary>
		/// Creates a return Message.
		/// </summary>
		/// <returns>A message representing the response for the processed message.</returns>
		public override Message CreateReturnMessage()
		{
			return new SDPFileResponse()
			{
				Guid = Message.Guid,
				SenderId = Message.SenderId,
				SDPFileContent = sdpFileContent,
			};
		}

		/// <summary>
		/// Writes data to SLProtocol, Engine, or another data destination.
		/// </summary>
		/// <param name="dataDestination">SLProtocol, Engine, or another data destination.</param>
		public override void DataSets(object dataDestination)
		{
			// Do nothing
		}

		/// <summary>
		/// Modifies retrieved data and Message data into a correct format for setting.
		/// </summary>
		public override void Modify()
		{
			// Do nothing
		}

		/// <summary>
		/// Parses the data retrieved from a data source in DataGets.
		/// </summary>
		public override void Parse()
		{
			// Do nothing
		}

		/// <summary>
		/// Validates received data for validity.
		/// </summary>
		/// <returns>A boolean indicating if the received data is valid.</returns>
		public override bool Validate()
		{
			return true;
		}
	}
}
