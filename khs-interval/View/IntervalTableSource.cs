using System;
using System.Collections.Generic;

using MonoTouch.UIKit;

using khs.interval.model;

namespace khs.interval.view
{
	public class IntervalTableSource : UITableViewSource
	{
		private Interval[] intervals;

		string cellIdentifier = "taskcell"; 
		public IntervalTableSource (Interval[] intervals) : base()
		{
			this.intervals = intervals;
		}

		public override int RowsInSection (UITableView tableview, int section)
		{
			return intervals.Length;
		}

		public override UITableViewCell GetCell (UITableView tableView, MonoTouch.Foundation.NSIndexPath indexPath)
		{
			// in a Storyboard, Dequeue will ALWAYS return a cell,
	        UITableViewCell cell = tableView.DequeueReusableCell (cellIdentifier);
	        // now set the properties as normal
	        cell.TextLabel.Text = intervals[indexPath.Row].Name;
//	        if (intervals[indexPath.Row].)
//	            cell.Accessory = UITableViewCellAccessory.Checkmark;
//	        else
//	            cell.Accessory = UITableViewCellAccessory.None;
	        return cell;

		}

		public Interval GetItem(int id) {
	        return intervals[id];
    	}

	}
}

