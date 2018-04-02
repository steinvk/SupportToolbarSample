using System;
using System.Collections.Generic;
using System.IO;
using Android.Graphics.Drawables;
using Android.Views;
using Android.Widget;

namespace SupportToolbarSample
{
    public class TeamsAdapter : BaseAdapter<Team>
    {
        List<Team> teams;
        public TeamsAdapter(List<Team> teams)
        {
            this.teams = teams;
        }

        public override Team this[int position]
        {
            get { return teams[position]; }    
            
        } 

        public override int Count => teams.Count;

        public override long GetItemId(int position)
        {
            return position;
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            var view = convertView;

            if(view == null)
            {
                view =  LayoutInflater.From(parent.Context).Inflate(Resource.Layout.teamRow, parent, false);

                var logo = view.FindViewById<ImageView>(Resource.Id.logoImageView);
                var name = view.FindViewById<TextView>(Resource.Id.nameTextView);
                var home = view.FindViewById<TextView>(Resource.Id.homeTextView);

                view.Tag = new ViewHolder() { Logo = logo, Name = name, Home = home };
            }

            var holder = (ViewHolder)view.Tag;
            holder.Name.Text = teams[position].Name;
            holder.Home.Text = teams[position].Home; 
            holder.Logo.SetImageDrawable(ImageAssetManager.Get(parent.Context,teams[position].ChestURL));

            return view;

        }
    }
}
