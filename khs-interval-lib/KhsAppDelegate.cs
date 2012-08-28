using System;
using MonoTouch.Foundation;
using MonoTouch.UIKit;
using TinyIoC;
using TinyMessenger;
using Vici.CoolStorage;

namespace khs.interval
{
	public abstract class KhsAppDelegate : UIApplicationDelegate
	{
		public override bool FinishedLaunching (UIApplication app, NSDictionary options)
		{	
			BootStrap();
			return true;
		}

		// This method is required in iPhoneOS 3.0
		public override void OnActivated (UIApplication application)
		{
		}

        public TinyIoCContainer Container { get; private set; }

//        private IRepository Repo 
//        { 
//            get { return Container.Resolve<IRepository>();}
//        }
        
        private ITinyMessengerHub MessageHub
        {            
            get{ return Container.Resolve<ITinyMessengerHub>();    }
        }

		private void BootStrap ()
        {
            Container = TinyIoCContainer.Current;
            Container.Register<ITinyMessengerHub, TinyMessengerHub> ().AsSingleton();
			Register(Container);
			InitializeDatabase();
//            Container.Register<IRepository, WebRepository> ();        
		}

		protected virtual void Register (TinyIoCContainer container)
		{
		}

		protected virtual void InitializeDatabase ()
		{
		}

	}
}

