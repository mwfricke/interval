// WARNING
//
// This file has been generated automatically by MonoDevelop to store outlets and
// actions made in the Xcode designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using MonoTouch.Foundation;

namespace khs.interval
{
	[Register ("IntervalDetailViewController")]
	partial class IntervalDetailViewController
	{
		[Outlet]
		MonoTouch.UIKit.UIBarButtonItem AddButton { get; set; }

		[Outlet]
		MonoTouch.UIKit.UITextField Name { get; set; }

		[Outlet]
		MonoTouch.UIKit.UITextView Instructions { get; set; }

		[Outlet]
		MonoTouch.UIKit.UITextField WarmUp { get; set; }

		[Outlet]
		MonoTouch.UIKit.UITextField Sets { get; set; }

		[Outlet]
		MonoTouch.UIKit.UIStepper SetsStepper { get; set; }

		[Outlet]
		MonoTouch.UIKit.UITextField Work { get; set; }

		[Outlet]
		MonoTouch.UIKit.UIStepper WorkStepper { get; set; }

		[Outlet]
		MonoTouch.UIKit.UITextField Duration { get; set; }

		[Outlet]
		MonoTouch.UIKit.UITextField Rest { get; set; }

		[Outlet]
		MonoTouch.UIKit.UITextField SetRest { get; set; }

		[Outlet]
		MonoTouch.UIKit.UITextField CoolDown { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (AddButton != null) {
				AddButton.Dispose ();
				AddButton = null;
			}

			if (Name != null) {
				Name.Dispose ();
				Name = null;
			}

			if (Instructions != null) {
				Instructions.Dispose ();
				Instructions = null;
			}

			if (WarmUp != null) {
				WarmUp.Dispose ();
				WarmUp = null;
			}

			if (Sets != null) {
				Sets.Dispose ();
				Sets = null;
			}

			if (SetsStepper != null) {
				SetsStepper.Dispose ();
				SetsStepper = null;
			}

			if (Work != null) {
				Work.Dispose ();
				Work = null;
			}

			if (WorkStepper != null) {
				WorkStepper.Dispose ();
				WorkStepper = null;
			}

			if (Duration != null) {
				Duration.Dispose ();
				Duration = null;
			}

			if (Rest != null) {
				Rest.Dispose ();
				Rest = null;
			}

			if (SetRest != null) {
				SetRest.Dispose ();
				SetRest = null;
			}

			if (CoolDown != null) {
				CoolDown.Dispose ();
				CoolDown = null;
			}
		}
	}
}
