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
    [Activity(Label = "ReportViewActivity")]
    public class ReportViewActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.ReportView);

            int ReportId = Convert.ToInt32(Intent.GetStringExtra("ReportID"));
            string Username = Intent.GetStringExtra("Username");

            var r = new ReportsReference.Reports();

            var report = r.GetSingle(Username, ReportId, true);


            FindViewById<TextView>(Resource.Id.textView1).Text = report.Title;

            FindViewById<TextView>(Resource.Id.textView2).Text = "by " + report.Username
                + "\r\nsubmited on " + report.Submit.ToShortDateString() + " " + report.Submit.ToShortTimeString()
                ;

            FindViewById<TextView>(Resource.Id.textView3).Text = report.Description;

        }
    }
}