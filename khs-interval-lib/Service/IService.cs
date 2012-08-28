using System;
using System.Collections.Generic;
using Vici.CoolStorage;

namespace khs.interval
{
	public interface IService<TObject> where TObject : CSObject<TObject>
	{
		TObject NewDomain();
		List<TObject> RetrieveAllObjects();
	}
}

