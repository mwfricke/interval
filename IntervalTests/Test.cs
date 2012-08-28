using System;
using System.Collections.Generic;
using NUnit.Framework;

using System.Data;
//using Mono.Data;
//using Mono.Data.Sqlite;
using khs.interval.model;
using khs.interval.service;


namespace IntervalTests
{
	[TestFixture()]
	public class Test
	{
	
		
		
		
		public void TestService() {
			
			
			IntervalService service = new IntervalService();
			Interval interval = new Interval();
			interval.Description = "Hello World";
			
			//service.Insert(interval);
				
			
			
		}
		
		
		
		
		public void DropTable() {
			
	/*		var conn = new SqliteConnection("Data Source=intervals;Version=3;Legacy Format=True;");


  			using (var cmd = conn.CreateCommand())

			{

  				conn.Open();				
				var cmd1 = conn.CreateCommand();
				cmd1.CommandText = "DROP TABLE interval;";
				cmd1.ExecuteNonQuery();
			}
			*/
			
		}
		
		[Test()]
		public void AllIntervals ()
		{
			
			IntervalService service = new IntervalService();
			
			Interval interval = new Interval();
			
			
		//	service.Insert(interval);
			
		//	List<Interval> intervals = service.FindAll();
			
			
			
		/*	var conn = new SqliteConnection("Data Source=intervals;Version=3;Legacy Format=True;");


  			using (var cmd = conn.CreateCommand())

			{

  				conn.Open();

  			//	cmd.CommandText ="SELECT name FROM sqlite_master WHERE type='table' ORDER BY name;";
				
			*/	
			
							
			}
			
		
		
			
	}
}

