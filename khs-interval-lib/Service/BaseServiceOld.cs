using System;
using System.Collections.Generic;
using Mono.Data.Sqlite;
using khs.interval.model;


namespace khs.interval.service
{
	public abstract class BaseService<T>
	{
			
		static public string IDCOLUMN = "Id";  	
	    public string DatabaseName {get; set; }
		
		
		public BaseService ()
		{
			
			
			
		}
		
		public string IDColumn() {
		
			return IDCOLUMN;
			
		}
		
		public void DropTable() {
			
			
			 var con = Connection();
			 try {
				
				
				var cmd1 = con.CreateCommand();
				cmd1.CommandText = "DROP TABLE interval;";
				cmd1.ExecuteNonQuery();
				
				   cmd1.Dispose();
                
		
														
				} catch (Exception e) {
						
					Console.WriteLine("Error dropp");
					Console.WriteLine(e);
				} finally {
				
				  con.Close();
				  con.Dispose();
				 
			}
																										
		}
		
		public void CreateDatabase() {
			
			var con = Connection();
			
			try {

				var cmd1 = con.CreateCommand();
				cmd1.CommandText = "CREATE TABLE interval (id INTEGER PRIMARY KEY ASC,description TEXT);";
				cmd1.ExecuteNonQuery();
		
				   cmd1.Dispose();
                 
				
				
				} catch (Exception e)  { Console.WriteLine("Error - "+e); }
			
			  finally {
				
				  con.Close();
				  con.Dispose();
				 
			}
			
			
				
			
		}
		
	
		 public SqliteConnection Connection() {

        
			SqliteConnection connection = new SqliteConnection("Data Source=intervalsDB");
			
			return connection;
        
		}
		
		
		public void Insert(T model) {
				
		  var insertSql = "INSERT INTO {0} ({1}) VALUES ({2})";
			
		  var sql = string.Format(insertSql,DatabaseName,FormatColumns(),FormatValues(model));	
			
		  ExecuteNonQuery(sql);		
			
			
		}
		
		
		public void Update(T model) {
				
		  var updateSql = "UPDATE {0} set {1} WHERE ID = {3}";
			
		  var sql = string.Format(updateSql,DatabaseName,FormatUpdateColumns(model),IDColumn(),IDValue(model));	
			
		  ExecuteNonQuery(sql);	
		  
			
			
		}
		
		
		public string FormatUpdateColumns(T model) {
			
			var cols = Columns();
			var values = Values(model);
			var result = new string[cols.Length];
			for (int i = 0 ; i < cols.Length ; i++) {
				
				result[i] = cols[i] + "="+ values[i];					
				
			}
			
			return string.Join(",",result);
			
		}
		
		
		public string FormatColumns() {		
			return string.Join(",",Columns());
		}
		
		public string FormatValues(T model) {			
			return string.Join(",",Values(model));	
			
		}
			
		
		public void ExecuteNonQuery(string sql) {
			
			var con = Connection();
			 try {
				con.Open();
				var cmd1 = con.CreateCommand();
				cmd1.CommandText = sql;
				cmd1.ExecuteNonQuery();
		   			
					cmd1.Dispose();
                  
				
														
				} catch (Exception e) {
						
					Console.WriteLine("Error"+e);
				} finally {
					con.Close ();
                    con.Dispose();
				
				}
			
			
		}
		
		
		public List<T> FindAll() {
		
		 List<T> results = new List<T>();
			
			// Data Access Code Starts
		// var conn = new SqliteConnection("Data Source=intervals");
		var conn = new SqliteConnection("Data Source=IntervalsDB");
	     using (var cmd = conn.CreateCommand())
		
		{
		
		  conn.Open();
			
		 cmd.CommandText = string.Format("select {0} from {1}",FormatColumns(),DatabaseName);
		
		  using(var reader = cmd.ExecuteReader())	
		  {
		
		    while (reader.Read())
		
		    {
		  		T model = NewModel();
		       Map(reader,model);	
		       results.Add(model);
		
		    }
		
				cmd.Dispose();
                conn.Close ();
                conn.Dispose();
		
					
			return results;
		
		    }

		}
			
			
			
		}
		
		
		public void Init() {
			
		//	DropTable();
		//	CreateDatabase();
			
			
		}
		
		
	    public abstract string[] Columns();
	    public abstract string[] Values(T model);
	    public abstract void Map(SqliteDataReader reader, T model);
	    public abstract T NewModel();
		public abstract string IDValue(T model);
		
		
		
	}
}

