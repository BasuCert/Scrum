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
    [Activity(Label = "NewActivity")]
    public class NewActivity : Activity
    {
        int selected_project_index = 0;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.NewReport);


            Spinner spinner = FindViewById<Spinner>(Resource.Id.spinner1);
            EditText title = FindViewById<EditText>(Resource.Id.editText1);
            EditText description = FindViewById<EditText>(Resource.Id.editText1);

            string Username = Intent.GetStringExtra("Username");

            var projects = // new List<Tuple<int, string>>();
                new ProjectsReference.Projects()
                .Get()
                .Select(x => new Tuple<int, string>(x.Id, x.Name))
                .ToList();



            spinner.Adapter = new ArrayAdapter(this, Android.Resource.Layout.SimpleListItem1, projects.Select(x => x.Item2).ToArray());
            spinner.ItemSelected += (sender, args) =>
            {
                selected_project_index = args.Position;
            };


            FindViewById<Button>(Resource.Id.button1).Click += delegate
            {
                ReportsReference.Reports r = new ReportsReference.Reports();
                r.Submit(title.Text, description.Text, DateTime.Now, true, projects[selected_project_index].Item1, true, Username);
                Toast.MakeText(this, "Done!", ToastLength.Long).Show();
                Finish();
            };

        }

    }
}