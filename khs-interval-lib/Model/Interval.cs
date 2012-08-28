using System;
using Mono.Data.Sqlite;
using Vici.CoolStorage;
	
namespace khs.interval.model
{

	[MapTo("interval")]
	public class Interval : CSObject<Interval, int>
	{
		
		//CYCLO-CROSS INTERVALS: Here’s a great workout from former national champion Tim Johnson. Warm up, then do two or three sets of 8x45 seconds “hard” with 1-minute recovery periods in between. Cool down for 5-10 minutes afterward. While you can do it outside, it’s also trainer friendly.
				
		public int Id {
			get { return (int) GetField ("Id"); }
		}

		public string Name 
		{ 
			get { return (string) GetField ("Name"); }
			set { SetField ("Name", value); }
		}

		public string Instructions 
		{ 
			get { return (string) GetField ("Instructions"); }
			set { SetField ("Instructions", value); }
		}

		public int WarmUp
		{ 
			get { return (int) GetField ("WarmUp"); }
			set { SetField ("WarmUp", value); }
		}

		public int Sets
		{ 
			get { return (int) GetField ("Sets"); }
			set { SetField ("Sets", value); }
		}

		public int Duration 
		{ 
			get { return (int) GetField ("Duration"); }
			set { SetField ("Duration", value); }
		}

		public int Recovery 
		{ 
			get { return (int) GetField ("Recovery"); }
			set { SetField ("Recovery", value); }
		}


		public int Rest 
		{ 
			get { return (int) GetField ("Rest"); }
			set { SetField ("Rest", value); }
		}

		public int Cooldown 
		{ 
			get { return (int) GetField ("Cooldown"); }
			set { SetField ("Cooldown", value); }
		}

		public Interval ()
		{
		}
	}
}

