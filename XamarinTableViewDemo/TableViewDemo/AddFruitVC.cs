﻿using System;
using System.Collections.Generic;
using UIKit;

namespace TableViewDemo
{
    public partial class ViewController : UIViewController
    {
        protected ViewController(IntPtr handle) : base(handle)
        {
            // Note: this .ctor should not contain any initialization logic.
        }

        public override void ViewDidLoad()
        {
            base.ViewDidLoad();
            // Perform any additional setup after loading the view, typically from a nib.
            List<string> fruits = new List<string> { "Banana", "Apple", "Pineapple" };
            NamesTableView.Source = new NamesTableViewSource(fruits);
        }

        public override void DidReceiveMemoryWarning()
        {
            base.DidReceiveMemoryWarning();
            // Release any cached data, images, etc that aren't in use.
        }
    }
}