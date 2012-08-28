using System;
using System.Collections.Generic;

using Vici.CoolStorage;

using khs.interval.model;

namespace khs.interval.service
{
	public class IntervalService : IService<Interval>
	{
		public IntervalService ()
		{
		}

		public Interval NewDomain ()
		{
			return Interval.New();
		}

		public List<Interval> RetrieveAllObjects ()
		{
			var csList = Interval.List();
			return csList.ToList();
		}

		public void Save (Interval interval)
		{
			interval.Save();
		}
	}
}

