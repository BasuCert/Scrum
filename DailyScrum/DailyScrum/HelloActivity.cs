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

namespace DailyScrum
{
    [Activity(Label = "HelloActivity")]
    public class HelloActivity : Activity
    {
        int last_loaded = 0;
        List<ReportsReference.ViewReport> data = new List<ReportsReference.ViewReport>();

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.Hello);

            string Username = Intent.GetStringExtra("Username");

            var btn_change_pass = FindViewById<Button>(Resource.Id.button1);
            var btn_new = FindViewById<Button>(Resource.Id.button2);
            var load_more = FindViewById<Button>(Resource.Id.button3);

            btn_change_pass.Click += delegate
            {
                Intent i = new Intent(this, typeof(ChangePassActivity));
                i.PutExtra("Username", Username);
                StartActivity(i);
            };
            btn_new.Click += delegate
            {
                Intent i = new Intent(this, typeof(NewActivity));
                i.PutExtra("Username", Username);
                StartActivity(i);
            };
            load_more.Click += delegate
            {
                MyRefresh(Username);
            };
            MyRefresh(Username);

        }
        List<ReportsReference.ViewReport> rs;
        private void MyRefresh(string Username)
        {
            ReportsReference.Reports reports = new ReportsReference.Reports();
            rs = reports.Get(Username, 10, true, last_loaded, true).ToList();
            foreach (var item in rs)
            {
                data.Add(item);
            }
            last_loaded = data.Count;
            ListView lv = FindViewById<ListView>(Resource.Id.listView1);
            var adapter = new HelloAdapter(this, data);
            lv.Adapter = adapter;
            lv.ItemClick += (sender, args) => 
            {
                Intent i = new Intent(this, typeof(ReportViewActivity));
                i.PutExtra("ReportID", rs[args.Position].Id.ToString());
                i.PutExtra("Username", Username);
                StartActivity(i);
            };
        }
    }
}