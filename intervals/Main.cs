
using System;
using System.Collections.Generic;
using System.Linq;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using MonoTouch.AudioToolbox;
using khs.interval;
using khs.interval.model;
using khs.interval.service;

namespace intervals
{
	public class Application
	{
		static void Main (string[] args)
		{
			UIApplication.Main (args);
		}
	}

	// The name AppDelegate is referenced in the MainWindow.xib file.
	public partial class AppDelegate : KhsAppDelegate
	{
		// This method is invoked when the application has loaded its UI and its ready to run
		public override bool FinishedLaunching (UIApplication app, NSDictionary options)
		{
			base.FinishedLaunching(app, options);
			
			
			IntervalService service = new IntervalService();
		    service.InitData();
			
			
			//SoundService sservice = new SoundService();
			//sservice.PlayCountDown();
			
			
			AudioSession.Initialize();   
			AudioSession.Category = AudioSessionCategory.MediaPlayback;   
			AudioSession.SetActive(true);   
	
			window.AddSubview (navigationController.View);
			window.MakeKeyAndVisible ();
			
			return true;
		}

		protected override void Register (TinyIoC.TinyIoCContainer container)
		{
			base.Register (container);
		}

		// This method is required in iPhoneOS 3.0
		public override void OnActivated (UIApplication application)
		{
		}
		
	}
		/*
		public override void WillTerminate (UIApplication application)
		{
			//Save data here
		}
		*/		
	}

