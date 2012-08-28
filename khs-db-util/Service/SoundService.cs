using System;
using MonoTouch.AudioToolbox;
using MonoTouch.Foundation;

namespace intervals
{
	public class SoundService
	{
		public SoundService ()
		{
		}
		
		public void PlayCountDown() {
			
			var sound = new SystemSound(new NSUrl("sounds/boxing_bell.m4v"));
			sound.PlaySystemSound();
			
			
		}
		
		public void PlayStart() {
			
			var sound = new SystemSound(new NSUrl("sounds/start.m4a"));
			//var sound = new SystemSound(new NSUrl("sounds/interval-startup-up.m4a"));
			sound.PlaySystemSound();		
			
		}
		
		
		public void PlayCoolDown() {
			
			var sound = new SystemSound(new NSUrl("sounds/boxing_bell.m4v"));
			sound.PlaySystemSound();		
			
		}
		
		
		
	}
}

