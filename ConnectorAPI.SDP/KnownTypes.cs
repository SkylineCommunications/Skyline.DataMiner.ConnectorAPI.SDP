namespace Skyline.DataMiner.ConnectorAPI.SDP
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	using System.Reflection;

	using Skyline.DataMiner.Core.InterAppCalls.Common.CallSingle;

	public static class KnownTypes
	{
		private static readonly Lazy<Type[]> _knownTypes = new Lazy<Type[]>(GetKnownTypes);

		public static ICollection<Type> Types => _knownTypes.Value;

		private static Type[] GetKnownTypes()
		{
			return Assembly.GetExecutingAssembly()
				.GetTypes()
				.Where(x => x.IsSubclassOf(typeof(Message)))
				.ToArray();
		}
	}
}
