// WARNING
//
// This file has been generated automatically by MonoDevelop to store outlets and
// actions made in the Xcode designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using MonoTouch.Foundation;

namespace khs.interval
{
	[Register ("StartViewController")]
	partial class StartViewController
	{
		[Outlet]
		MonoTouch.UIKit.UILabel NameTextField { get; set; }

		[Outlet]
		MonoTouch.UIKit.UILabel TimerTextField { get; set; }

		[Outlet]
		MonoTouch.UIKit.UIButton PauseButton { get; set; }

		[Outlet]
		MonoTouch.UIKit.UIButton CancelButton { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (NameTextField != null) {
				NameTextField.Dispose ();
				NameTextField = null;
			}

			if (TimerTextField != null) {
				TimerTextField.Dispose ();
				TimerTextField = null;
			}

			if (PauseButton != null) {
				PauseButton.Dispose ();
				PauseButton = null;
			}

			if (CancelButton != null) {
				CancelButton.Dispose ();
				CancelButton = null;
			}
		}
	}
}
