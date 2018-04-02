
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Support.V7.Widget;
using Android.Views;
using Android.Widget;

namespace SupportToolbarSample
{
    [Activity(Label = "DetailsActivity")]
    public class DetailsActivity : Android.Support.V7.App.AppCompatActivity
    {
        Android.Support.V7.Widget.Toolbar toolbar;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.details);
            toolbar = FindViewById<Android.Support.V7.Widget.Toolbar>(Resource.Id.toolbar);
            SetSupportActionBar(toolbar);
            SupportActionBar.SetDisplayHomeAsUpEnabled(true);
            SupportActionBar.SetHomeAsUpIndicator(Resource.Drawable.ic_arrow_back_white_24dp);


            int id = Intent.GetIntExtra("id", -1);

            TextView teamName = FindViewById<TextView>(Resource.Id.teamName);
            ImageView logo = FindViewById<ImageView>(Resource.Id.logo);
            TextView homeTextView = FindViewById<TextView>(Resource.Id.homeTextView);

            Team team = TeamManager.Teams[id];
            if(team != null)
            {
                teamName.Text = team.Name;
                SupportActionBar.SetTitle(Resource.String.details);
                logo.SetImageDrawable(ImageAssetManager.Get(this, team.ChestURL));
                homeTextView.Text = team.Home;

            }

        }

		public override bool OnCreateOptionsMenu(IMenu menu)
		{
            base.MenuInflater.Inflate(Resource.Menu.actions,menu);
            return true;
		}


		public override bool OnOptionsItemSelected(IMenuItem item)
		{
            switch(item.ItemId)
            {
                case Android.Resource.Id.Home:
                    Finish();
                    break;

                
            }
            return true;
		}
		
    }
}
