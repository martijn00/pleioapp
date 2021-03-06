﻿using System;
using System.Collections.Generic;

using Xamarin.Forms;

namespace Pleioapp
{
	public partial class GroupPage : TabbedPage
	{
		ActivityPage activityPage;
		EventPage eventPage;
		MemberPage memberPage;

		public GroupPage ()
		{
			InitializeComponent ();

			activityPage = new ActivityPage ();
			eventPage = new EventPage ();
			memberPage = new MemberPage ();

			Children.Add (activityPage);
			Children.Add (eventPage);
			Children.Add (memberPage);

			MessagingCenter.Subscribe<Xamarin.Forms.Application> (App.Current, "select_group", async(sender) => {
				var app = (App)App.Current;
				BindingContext = app.currentGroup;
			});
		}
	}
}

