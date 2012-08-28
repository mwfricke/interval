using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

using MonoTouch.Foundation;
using MonoTouch.UIKit;

using Vici.CoolStorage;

namespace khs.interval
{
	// The UIApplicationDelegate for the application. This class is responsible for launching the 
	// User Interface of the application, as well as listening (and optionally responding) to 
	// application events from iOS.
	[Register ("AppDelegate")]
	public partial class AppDelegate : KhsAppDelegate
	{
		// class-level declarations

		public override UIWindow Window {
			get;
			set;
		}

		public override bool FinishedLaunching (UIApplication app, NSDictionary options)
		{
			base.FinishedLaunching (app, options);

			return true;
		}
		
		//
		// This method is invoked when the application is about to move from active to inactive state.
		//
		// OpenGL applications should use this method to pause.
		//
		public override void OnResignActivation (UIApplication application)
		{
		}
		
		// This method should be used to release shared resources and it should store the application state.
		// If your application supports background exection this method is called instead of WillTerminate
		// when the user quits.
		public override void DidEnterBackground (UIApplication application)
		{
		}
		
		// This method is called as part of the transiton from background to active state.
		public override void WillEnterForeground (UIApplication application)
		{
		}
		
		// This method is called when the application is about to terminate. Save data, if needed. 
		public override void WillTerminate (UIApplication application)
		{
		}

		protected override void InitializeDatabase ()
		{
			CSConfig.SetDB(DbName, SqliteOption.CreateIfNotExists,  () => 
				{
					CSDatabase.ExecuteNonQuery(@"CREATE TABLE IF NOT EXISTS interval
								(Id INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL, 
								Name VARCHAR(50), 
								Instructions VARCHAR(50), 
								WarmUp DATETIME NOT NULL , 
								Sets INTEGER NOT NULL , 
								Duration DATETIME NOT NULL , 
								Recovery DATETIME NOT NULL , 
								Rest DATETIME NOT NULL , 
								Cooldown DATETIME NOT NULL");
					CSDatabase.ExecuteNonQuery(@"CREATE TABLE effort 
								(Id INTEGER PRIMARY KEY AUTOINCREMENT NOT NULL , 
								IntervalId INTEGER NOT NULL , 
								Type VARCHAR(30), 
								DateTime DATETIME, 
								Notes VARCHAR(50))");

				}
			);
		}

		public string DbName
		{
			get { return Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Personal), "interval.db3"); }
		}
	}
}

