namespace Skyline.DataMiner.ConnectorAPI.SDP
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Reflection;

	using Skyline.DataMiner.Core.InterAppCalls.Common.CallSingle;

	public static class KnownTypes
	{
		public static IEnumerable<Type> GetList()
		{
			return Assembly.GetExecutingAssembly()
				.GetTypes()
				.Where(x => x.IsSubclassOf(typeof(Message)));
		}
	}
}
