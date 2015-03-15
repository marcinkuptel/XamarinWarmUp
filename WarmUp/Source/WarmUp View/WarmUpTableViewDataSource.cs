using System;
using UIKit;

namespace WarmUp
{
	public class WarmUpTableViewDataSource: UITableViewSource
	{
		string [] tableItems;
		string cellIdentifier = "TableCell";

		public WarmUpTableViewDataSource (string[] items)
		{
			tableItems = items;
		}

		#region Overriden

		public override nint RowsInSection(UITableView tableView, nint section)
		{
			return tableItems.Length;
		}

		public override UITableViewCell GetCell(UITableView tableView, Foundation.NSIndexPath indexPath)
		{
			UITableViewCell cell = tableView.DequeueReusableCell(cellIdentifier);
			if (cell == null) 
			{
				cell = new UITableViewCell (UITableViewCellStyle.Default, cellIdentifier);
			}
			cell.TextLabel.Text = tableItems [indexPath.Row];
			return cell;
		}

		public override void RowSelected (UITableView tableView, Foundation.NSIndexPath indexPath)
		{
			new UIAlertView("Row Selected", tableItems[indexPath.Row], null, "OK", null).Show();
			tableView.DeselectRow (indexPath, true);
		}

		#endregion
	}
}

