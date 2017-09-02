using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using DailyScrum.ReportsReference;
using Java.Lang;

namespace DailyScrum
{
    class HelloAdapter : BaseAdapter
    {
        //ReportsReference.Report[] data;  
        List<ReportsReference.ViewReport> data;
        Activity context;

        public HelloAdapter(Activity Context, List<ReportsReference.ViewReport> Data)
        {
            data = Data;
            context = Context;
        }


        public override int Count
        {
            get
            {
                return data.Count;
            }
        }

        public override Java.Lang.Object GetItem(int position)
        {
            return position;
        }

        public override long GetItemId(int position)
        {
            return position;
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            if (convertView == null)
                convertView = context.LayoutInflater.Inflate(Resource.Layout.HelloItem, null);

            TextView title;
            TextView description;

            title = convertView.FindViewById<TextView>(Resource.Id.textView1);
            description = convertView.FindViewById<TextView>(Resource.Id.textView2);

            title.Text = data[position].Title;
            description.Text = data[position].Username;

            return convertView;
        }
    }
}