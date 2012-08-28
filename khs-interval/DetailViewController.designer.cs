// WARNING
//
// This file has been generated automatically by MonoDevelop to store outlets and
// actions made in the Xcode designer. If it is removed, they will be lost.
// Manual changes to this file may not be handled correctly.
//
using MonoTouch.Foundation;

namespace khs.interval
{
	[Register ("DetailViewController")]
	partial class DetailViewController
	{
		[Outlet]
		MonoTouch.UIKit.UILabel detailDescriptionLabel { get; set; }

		[Outlet]
		MonoTouch.UIKit.UIToolbar toolbar { get; set; }

		[Outlet]
		MonoTouch.UIKit.UITextField NameTextField { get; set; }

		[Outlet]
		MonoTouch.UIKit.UITextField SetsTextField { get; set; }

		[Outlet]
		MonoTouch.UIKit.UITextField RecoveryTextField { get; set; }

		[Outlet]
		MonoTouch.UIKit.UISegmentedControl SecondsIndicator { get; set; }

		[Outlet]
		MonoTouch.UIKit.UITextView InstructionsTextField { get; set; }

		[Outlet]
		MonoTouch.UIKit.UITextField DurationTextField { get; set; }

		[Outlet]
		MonoTouch.UIKit.UITextField RepitionsTextField { get; set; }
		
		void ReleaseDesignerOutlets ()
		{
			if (detailDescriptionLabel != null) {
				detailDescriptionLabel.Dispose ();
				detailDescriptionLabel = null;
			}

			if (toolbar != null) {
				toolbar.Dispose ();
				toolbar = null;
			}

			if (NameTextField != null) {
				NameTextField.Dispose ();
				NameTextField = null;
			}

			if (SetsTextField != null) {
				SetsTextField.Dispose ();
				SetsTextField = null;
			}

			if (RecoveryTextField != null) {
				RecoveryTextField.Dispose ();
				RecoveryTextField = null;
			}

			if (SecondsIndicator != null) {
				SecondsIndicator.Dispose ();
				SecondsIndicator = null;
			}

			if (InstructionsTextField != null) {
				InstructionsTextField.Dispose ();
				InstructionsTextField = null;
			}

			if (DurationTextField != null) {
				DurationTextField.Dispose ();
				DurationTextField = null;
			}

			if (RepitionsTextField != null) {
				RepitionsTextField.Dispose ();
				RepitionsTextField = null;
			}
		}
	}
}
