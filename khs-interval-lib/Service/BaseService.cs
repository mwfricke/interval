using System;
using System.Collections.Generic;

using Vici.CoolStorage;

namespace khs.interval.service
{
	public abstract class BaseService<TObject> : IService<TObject> where TObject : CSObject<TObject>
	{
		public TObject NewDomain ()
		{
			return null;
		}

		public List<TObject> RetrieveAllObjects ()
		{
			return null;
		}
	}
}

