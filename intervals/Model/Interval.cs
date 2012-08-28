using System;
using Mono.Data.Sqlite;

	
namespace khs.interval.model
{
	public class Interval
	{
		
		//CYCLO-CROSS INTERVALS: Here’s a great workout from former national champion Tim Johnson. Warm up, then do two or three sets of 8x45 seconds “hard” with 1-minute recovery periods in between. Cool down for 5-10 minutes afterward. While you can do it outside, it’s also trainer friendly.
		
		
		public long Id {get; set;}
		public string Name {get; set;}
		public string Type {get; set;}
		public string Description {get; set;}
		public string Instructions {get; set; }
		public long Duration {get; set; }
		public bool Seconds{get;set;}	
		public long Recovery {get;set;}
		public long Sets {get; set;}
		public long Cooldown {get; set; }
		public long Count {get; set; }
		public string Why {get; set;}
	
								
		public Interval ()
		{
		}
	}
}

