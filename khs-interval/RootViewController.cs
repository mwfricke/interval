// This file has been autogenerated from parsing an Objective-C header file added in Xcode.

using System;
using System.Collections.Generic;

using MonoTouch.Foundation;
using MonoTouch.UIKit;

using khs.interval.model;
using khs.interval.view;

namespace khs.interval
{
	public partial class RootViewController : UITableViewController
	{

		public RootViewController (IntPtr handle) : base (handle) 
		{
		}

		private List<Interval> Intervals {
			get 
			{
				var list = Interval.List();
				if ( list != null ) {
					return list.ToList();
				}
				return null;
			}
		}


		#region View lifecycle
		
		public override void ViewDidLoad ()
		{
			base.ViewDidLoad ();

			// Perform any additional setup after loading the view, typically from a nib.
			AddButton.Clicked += (sender, e) => {
				CreateTask ();
			};
		}

		public override void PrepareForSegue (UIStoryboardSegue segue, NSObject sender)
		{
			if (segue.Identifier == "SegueDetail") { // set in Storyboard
				var navctlr = (DetailViewController) segue.DestinationViewController;
				if (navctlr != null) {
					var row = TableView.IndexPathForSelectedRow;
					var source = (IntervalTableSource) TableView.Source;
					var item = source.GetItem(row.Row);
					navctlr.SetInterval(this, item);
				}
			}
		}

		public void CreateTask () {
			var newInterval = Interval.New();
			var detail = (DetailViewController) Storyboard.InstantiateViewController("detail");
			detail.SetInterval (this, newInterval);
			NavigationController.PushViewController (detail, true);
		}

		public override void ViewDidUnload ()
		{
			base.ViewDidUnload ();
			
			// Clear any references to subviews of the main view in order to
			// allow the Garbage Collector to collect them sooner.
			//
			// e.g. myOutlet.Dispose (); myOutlet = null;
			
//			ReleaseDesignerOutlets ();
		}
		
		public override void ViewWillAppear (bool animated)
		{
			base.ViewWillAppear (animated);

			// bind every time, to reflect deletion in the Detail view
			TableView.Source = new IntervalTableSource(Intervals.ToArray ());
		}
		
		public override void ViewDidAppear (bool animated)
		{
			base.ViewDidAppear (animated);
		}
		
		public override void ViewWillDisappear (bool animated)
		{
			base.ViewWillDisappear (animated);
		}
		
		public override void ViewDidDisappear (bool animated)
		{
			base.ViewDidDisappear (animated);
		}
		
		#endregion
	}
}
