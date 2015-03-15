// WARNING
//
// This file has been generated automatically by Xamarin Studio from the outlets and
// actions declared in your storyboard file.
// Manual changes to this file will not be maintained.
//
using Foundation;
using System;
using System.CodeDom.Compiler;
using UIKit;

namespace WarmUp
{
	[Register ("WarmUpViewController")]
	partial class WarmUpViewController
	{
		[Outlet]
		[GeneratedCode ("iOS Designer", "1.0")]
		UITableView warmUpTableView { get; set; }

		void ReleaseDesignerOutlets ()
		{
			if (warmUpTableView != null) {
				warmUpTableView.Dispose ();
				warmUpTableView = null;
			}
		}
	}
}
