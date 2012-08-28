using System;
using Mono.Data;
using Mono.Data.Sqlite;
namespace khs.dbutil
{
	public class Table
	{
		
		private Column[] Columns {get;set;}
		private string Name {get; set; }
		
		// STATEMENTS 
		private static string CREATE = "CREATE TABLE {0} ({1});";
		private static string DROP = "DROP TABLE {0};";
		
		
		public Table (string name,params Column[] cols)
		{
			Columns = cols;
			Name = name;					
		}
		

		public void Create(SqliteConnection conn) {
						
			
			using (var cmd = conn.CreateCommand())
			{
  				conn.Open();
				string cols = "";
				foreach (var col in Columns) { 
  					cols += col;			
				}
								
			//	cmd.CommandText = string.Format(CREATE,Name,Columns());
				
			}
			
			
		}
		
		
		
		
	}
}

