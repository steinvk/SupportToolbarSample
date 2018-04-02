using Android.App;
using Android.Widget;
using Android.OS;
using System;
using System.Collections.Generic;
using Android.Content;

namespace SupportToolbarSample
{
    [Activity(Label = "SupportToolbarSample", MainLauncher = true, Icon = "@mipmap/icon")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            // Get our button from the layout resource,
            // and attach an event to it
            ListView teamsListView = FindViewById<ListView>(Resource.Id.teamsListView);
            teamsListView.ItemClick += OnItemClicked;
            var teams = TeamManager.Teams;
            var adapter = new TeamsAdapter(teams);
            teamsListView.Adapter = adapter;
        }

        private void OnItemClicked(object sender, AdapterView.ItemClickEventArgs e)
        {

            Intent intent = new Intent(this, typeof(DetailsActivity));
            intent.PutExtra("id", e.Position);
            StartActivity(intent);


        }
    }
}

