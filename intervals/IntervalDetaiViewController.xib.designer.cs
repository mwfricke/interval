// ------------------------------------------------------------------------------
//  <autogenerated>
//      This code was generated by a tool.
//      Mono Runtime Version: 2.0.50727.1433
// 
//      Changes to this file may cause incorrect behavior and will be lost if 
//      the code is regenerated.
//  </autogenerated>
// ------------------------------------------------------------------------------

namespace intervals {
	
	
	// Base type probably should be MonoTouch.UIKit.UIViewController or subclass
	[MonoTouch.Foundation.Register("IntervalDetaiViewController")]
	public partial class IntervalDetaiViewController {
		
		private MonoTouch.UIKit.UIView __mt_view;
		
		private MonoTouch.UIKit.UITextField __mt_recovery;
		
		private MonoTouch.UIKit.UITextField __mt_duration;
		
		private MonoTouch.UIKit.UITextField __mt_repititions;
		
		private MonoTouch.UIKit.UITextField __mt_sets;
		
		private MonoTouch.UIKit.UISegmentedControl __mt_durationToggle;
		
		private MonoTouch.UIKit.UISegmentedControl __mt_recoveryToggle;
		
		private MonoTouch.UIKit.UITextField __mt_nameLabel;
		
		private MonoTouch.UIKit.UIButton __mt_startButton;
		
		private MonoTouch.UIKit.UITextView __mt_instructions;
		
		#pragma warning disable 0169
		[MonoTouch.Foundation.Connect("view")]
		private MonoTouch.UIKit.UIView view {
			get {
				this.__mt_view = ((MonoTouch.UIKit.UIView)(this.GetNativeField("view")));
				return this.__mt_view;
			}
			set {
				this.__mt_view = value;
				this.SetNativeField("view", value);
			}
		}
		
		[MonoTouch.Foundation.Connect("recovery")]
		private MonoTouch.UIKit.UITextField recovery {
			get {
				this.__mt_recovery = ((MonoTouch.UIKit.UITextField)(this.GetNativeField("recovery")));
				return this.__mt_recovery;
			}
			set {
				this.__mt_recovery = value;
				this.SetNativeField("recovery", value);
			}
		}
		
		[MonoTouch.Foundation.Connect("duration")]
		private MonoTouch.UIKit.UITextField duration {
			get {
				this.__mt_duration = ((MonoTouch.UIKit.UITextField)(this.GetNativeField("duration")));
				return this.__mt_duration;
			}
			set {
				this.__mt_duration = value;
				this.SetNativeField("duration", value);
			}
		}
		
		[MonoTouch.Foundation.Connect("repititions")]
		private MonoTouch.UIKit.UITextField repititions {
			get {
				this.__mt_repititions = ((MonoTouch.UIKit.UITextField)(this.GetNativeField("repititions")));
				return this.__mt_repititions;
			}
			set {
				this.__mt_repititions = value;
				this.SetNativeField("repititions", value);
			}
		}
		
		[MonoTouch.Foundation.Connect("sets")]
		private MonoTouch.UIKit.UITextField sets {
			get {
				this.__mt_sets = ((MonoTouch.UIKit.UITextField)(this.GetNativeField("sets")));
				return this.__mt_sets;
			}
			set {
				this.__mt_sets = value;
				this.SetNativeField("sets", value);
			}
		}
		
		[MonoTouch.Foundation.Connect("durationToggle")]
		private MonoTouch.UIKit.UISegmentedControl durationToggle {
			get {
				this.__mt_durationToggle = ((MonoTouch.UIKit.UISegmentedControl)(this.GetNativeField("durationToggle")));
				return this.__mt_durationToggle;
			}
			set {
				this.__mt_durationToggle = value;
				this.SetNativeField("durationToggle", value);
			}
		}
		
		[MonoTouch.Foundation.Connect("recoveryToggle")]
		private MonoTouch.UIKit.UISegmentedControl recoveryToggle {
			get {
				this.__mt_recoveryToggle = ((MonoTouch.UIKit.UISegmentedControl)(this.GetNativeField("recoveryToggle")));
				return this.__mt_recoveryToggle;
			}
			set {
				this.__mt_recoveryToggle = value;
				this.SetNativeField("recoveryToggle", value);
			}
		}
		
		[MonoTouch.Foundation.Connect("nameLabel")]
		private MonoTouch.UIKit.UITextField nameLabel {
			get {
				this.__mt_nameLabel = ((MonoTouch.UIKit.UITextField)(this.GetNativeField("nameLabel")));
				return this.__mt_nameLabel;
			}
			set {
				this.__mt_nameLabel = value;
				this.SetNativeField("nameLabel", value);
			}
		}
		
		[MonoTouch.Foundation.Connect("startButton")]
		private MonoTouch.UIKit.UIButton startButton {
			get {
				this.__mt_startButton = ((MonoTouch.UIKit.UIButton)(this.GetNativeField("startButton")));
				return this.__mt_startButton;
			}
			set {
				this.__mt_startButton = value;
				this.SetNativeField("startButton", value);
			}
		}
		
		[MonoTouch.Foundation.Connect("instructions")]
		private MonoTouch.UIKit.UITextView instructions {
			get {
				this.__mt_instructions = ((MonoTouch.UIKit.UITextView)(this.GetNativeField("instructions")));
				return this.__mt_instructions;
			}
			set {
				this.__mt_instructions = value;
				this.SetNativeField("instructions", value);
			}
		}
	}
	
	// Base type probably should be MonoTouch.UIKit.UIViewController or subclass
	[MonoTouch.Foundation.Register("IntervalDetailViewController")]
	public partial class IntervalDetailViewController {
	}
}
