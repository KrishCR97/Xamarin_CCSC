using System;
using System.Collections.Generic;
using Foundation;
using UIKit;
namespace TableViewDemo
{
    public class NamesTableViewSource : UITableViewSource
    {
        public List<string> fruits;

        public NamesTableViewSource()
        {
        }

        public NamesTableViewSource(List<string> fruits)
        {
            this.fruits = fruits;
        }

        public override UITableViewCell GetCell(UITableView tableView, NSIndexPath indexPath)
        {
            var cell = new UITableViewCell(UITableViewCellStyle.Default, "");
            cell.TextLabel.Text = fruits[indexPath.Row];
            return cell;
        }

        public override nint RowsInSection(UITableView tableview, nint section)
        {
            return fruits.Count;
        }
    }
}
