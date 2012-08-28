using System;
using Vici.CoolStorage;
namespace khs.interval.model
{
	public class Workout : CSObject<Workout, int>
	{
		
		public int Id 
		{
			get { return (int) GetField ("Id"); }
		}

		public string Description 
		{	
			get { return (string) GetField ("Description"); }
			set { SetField ("Description", value); }
		}
		
		
		public Workout ()
		{
		}
	}
}

