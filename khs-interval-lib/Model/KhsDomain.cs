using System;
using Vici.CoolStorage;

namespace khs.interval.model
{
	[MapTo("interval")]
	public abstract class KhsDomain<TObject> : CSObject<TObject, int> where TObject : CSObject<TObject>
	{
		public KhsDomain ()
		{
		}

		public int Id {
			get { return (int) GetField ("Id"); }
		}

	}
}

