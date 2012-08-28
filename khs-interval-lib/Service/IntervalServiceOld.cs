using System;
using System.Collections.Generic;
using khs.interval.model;
using Mono.Data.Sqlite;



namespace khs.interval.service
{
	public class IntervalService : BaseService<Interval>
	{
		
		
		private static List<Interval> Intervals {get; set; }
		
		public IntervalService () 
		{
		    
			DatabaseName = "interval";
			Intervals = AllIntervals();
			
			
		}
		
		public List<Interval> AllIntervals() {
			
			 
			List<Interval> intervals = FindAll();		
			
			
			return intervals;			
			
		}
		
		
		public int Count() {
			
			return FindAll().Count;
		}
		
		
		public Interval GetInterval(int index) {
						
			List<Interval> all = FindAll();
			if (all.Count > 0 && index >= 0) {
				
				return all[index];	
			}
			
			
			return null;	
			
		}
		
     	public override string[] Columns() {
			
			return new string[] { "Id", "Description","Name","Instructions","Recovery","Seconds","Sets","Duration","Cooldown","Count"};							
			
		}
		
		public override string[] Values(Interval model) 
		{ 
		
			return new string[] {  };
//			return new string[] {N(model.Id),
//								 S(model.Description),
//								 S(model.Name),
//								 S(model.Instructions),
//								 N(model.Recovery),
//								 B(model.Seconds),
//							 	 N(model.Sets),
//								 N(model.Duration),
//				  				 N(model.Cooldown),
//								 N(model.Count)};
		}
		
		private string N(long o) {
			
		return o.ToString();	
		
		}
		private string S(string q) {
			
			return "'"+q+"'";	
		}
		
		private string B(bool b) {
			
			return b ? "1": "0";	
		}
		
		public override Interval NewModel() {
			
		  return new Interval();	
		}
		
		
	    public override string IDValue(Interval model) {
						
		 return ""+model.Id;
			
		}
		
	    
		
		
		public override void Map(SqliteDataReader reader,Interval interval) {
			
//			Interval mapped = (Interval) interval;
//			mapped.Id = int.Parse(reader["Id"].ToString());
//			mapped.Name = reader["Name"].ToString();
//			mapped.Description = reader["Description"].ToString();
//			mapped.Instructions = reader["Instructions"].ToString();
//			mapped.Recovery = int.Parse(reader["Recovery"].ToString());
//			mapped.Seconds =  int.Parse(reader["Seconds"].ToString()) > 0;
//			mapped.Sets = int.Parse(reader["Sets"].ToString());
//			mapped.Count = int.Parse(reader["Count"].ToString());
//			mapped.Duration = int.Parse(reader["Duration"].ToString());
//			mapped.Cooldown = int.Parse(reader["Cooldown"].ToString());
		
			
			
		}	
		
		
		public void InitData() {
			
			
//			Interval interval = new Interval();
//			interval.Id = 100;
//			interval.Name = "Cyclo Cross (1 x 10)";
//			interval.Description = "1 x 10";
//			interval.Instructions = "Warm up, then do go hard with 1-minute recovery periods in between. Cool down for 5-10 minutes afterward. While you can do it outside, it’s also trainer friendly.";
//			interval.Sets = 3;
//			interval.Duration= 45;
//			interval.Seconds = true;
//			interval.Count = 8;
//			interval.Recovery = 1;
//			interval.Why = "Make you fast";
//			
//			
//			IntervalService service = new IntervalService();
//			service.Insert(interval);
			
			
			
			
		}
		
		
		
		
	}
}

