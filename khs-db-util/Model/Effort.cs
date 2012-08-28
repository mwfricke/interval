using System;
namespace khs.intervals.model
{
	public class Effort
	{

		public long Id {get; set;}
		public DateTime DateTime {get; set;}
		public long IntervalId {get; set;}
		public string Notes {get; set;}
		
		public Effort ()
		{
		}
				
	}
}

