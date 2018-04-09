using Foundation;
using System;
using UIKit;

namespace TableViewDemo
{
    public partial class AddFruitVC : UIViewController
    {
        public AddFruitVC (IntPtr handle) : base (handle)
        {
        }

        partial void UIButton1069_TouchUpInside(UIButton sender)
        {
            //NamesTableViewSource.fruits.Add(fruitTF.Text);
            AppDelegate.fruits.Add(fruitTF.Text.ToString());
        }
    }
}