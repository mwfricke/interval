using System;
using Vici.CoolStorage;

namespace khs.interval.model
{
	[MapTo("effort")]
	public class Effort : CSObject<Effort, int> 
	{

		public int Id 
		{
			get { return (int) GetField ("Id"); }
		}

		public DateTime DateTime 
		{	
			get { return (DateTime) GetField ("DateTime"); }
			set { SetField ("DateTime", value); }
		}

		[ManyToOne]
		public Interval Interval { get; set;}

		public string Notes
		{
			get { return (string) GetField ("Notes"); }
			set { SetField ("Notes", value); }
		}

		public string Type
		{
			get { return (string) GetField ("Type"); }
			set { SetField ("Type", value); }
		}

		public Effort ()
		{
		}
				
	}
}

