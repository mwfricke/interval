
using System;
using System.Collections.Generic;
using System.Linq;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using MonoTouch.AudioToolbox;
using khs.interval.service;
using khs.interval.model;
using System.Threading;

namespace intervals
{
	public partial class IntervalDetaiViewController : UIViewController
	{
	
		public IntervalService IntervalSevice {get; set;}
		public SoundService SoundService {get; set;}
		public Interval Item {get; set; }
		private UIColor _savedColor = null;
		
		#region Constructors

		// The IntPtr and initWithCoder constructors are required for items that need 
		// to be able to be created from a xib rather than from managed code
			
		public IntervalDetaiViewController (IntPtr handle) : base(handle)
		{
			Initialize ();
		}

		public IntervalDetaiViewController(string nibName,NSBundle bundle) : base (nibName,bundle) 
		{
			Initialize();
		}
				
		
		[Export("initWithCoder:")]
		public IntervalDetaiViewController (NSCoder coder) : base(coder)
		{
			Initialize ();
		}

		public IntervalDetaiViewController () : base("IntervalDetaiViewController", null)
		{
			Initialize ();
		}

		void Initialize ()
		{
			
			IntervalSevice = new IntervalService();
			SoundService = new SoundService();
			
		}
		
		#endregion
		
		public override void ViewWillAppear (bool animated)
		{
			base.ViewWillAppear (animated);
			
			startButton.TouchDown += delegate {
				//SoundService.PlayCountDown();
				
			    	
			   for (int i = 0; i < 10 ; i++) {
				  SoundService.PlayStart();
				  Thread.Sleep(600);
				}
				
				
				
			};
			
			UIBarButtonItem item = new UIBarButtonItem();
			item.Title = "Edit";
			//SystemSound sound = SystemSound.FromFile("sounds/boxing_bell.wav");
			item.Clicked += delegate { 
				
				if (item.Title.Equals("Edit")) {
					    item.Title = "Save"; 
						EnableEdit();
						//GetItems();
					
					
			}
			else {
					
						item.Title = "Edit";
							ApplyEdit();
					
					
				}
				  };
			this.NavigationItem.SetRightBarButtonItem(item,true);
			
			
			this.nameLabel.Text = Item.Name;
			this.instructions.Text = Item.Instructions;
			this.duration.Text = Item.Duration.ToString();
//			this.sets.Text = Item.Sets.ToString();
			this.duration.Text = Item.Duration.ToString();
			this.recovery.Text = Item.Recovery.ToString();
			
			
			this.durationToggle.ValueChanged += delegate {  Item.Seconds = false;   };
			
			
		}
		
		private void EnableEdit() {
			
			   _savedColor = this.sets.BackgroundColor;
			   this.nameLabel.Selected = true;
			   this.nameLabel.Enabled = true;
			   this.sets.Enabled = true;
			   this.recovery.Enabled = true;
			   this.recoveryToggle.Enabled = true;
			   this.instructions.Editable = true;
			   this.duration.Enabled = true;
			   
			   
			   this.sets.BackgroundColor = UIColor.Red;
			   this.nameLabel.BackgroundColor = UIColor.Red;
			   this.recovery.BackgroundColor = UIColor.Red;
			   this.duration.BackgroundColor = UIColor.Red;
			   this.recoveryToggle.Enabled = true;
				
		
				
		}
				
			private void ApplyEdit() {
			
			  
			   
			   this.nameLabel.Enabled = false;
			   this.sets.Enabled = false;
			   this.recovery.Enabled = false;
			   this.recoveryToggle.Enabled = false;
			   this.duration.Enabled = false;
			   this.instructions.Editable = false;
			   
			   this.sets.BackgroundColor = _savedColor;
			   this.nameLabel.BackgroundColor = _savedColor;
			   this.recovery.BackgroundColor = _savedColor;
			   this.instructions.BackgroundColor = _savedColor;
			   this.duration.BackgroundColor = _savedColor;
			   	
			   
//			   Item.Sets = Int16.Parse(sets.Text);
			   Item.Recovery = Int16.Parse(this.recovery.Text);
			   Item.Duration = Int16.Parse(this.duration.Text);
			   Item.Instructions = this.instructions.Text;
			 
		       IntervalSevice.Update(Item);
		
		
		
		}
	
		
		
	}
}

