using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using System.Data.SqlClient;

namespace DailyScrum
{
    [Activity(Label = "DailyScrum", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);
            SetContentView(Resource.Layout.Main);


            EditText username = FindViewById<EditText>(Resource.Id.editText1);
            EditText password = FindViewById<EditText>(Resource.Id.editText2);

            Button button = FindViewById<Button>(Resource.Id.button1);

            button.Click += delegate
            {

                var t = new UsersReference.Users();

                bool result = false;
                bool _result = false;

                t.Login(username.Text, password.Text, out result, out _result);

                if (result)
                {
                    Intent i = new Intent(this, typeof(HelloActivity));
                    i.PutExtra("Username", username.Text);
                    StartActivity(i);
                    Toast.MakeText(this, "Welcome " + username.Text, ToastLength.Long).Show();
                    Finish();
                }
                else
                {
                    Toast.MakeText(this, "Username or password is invalid", ToastLength.Long).Show();
                }
            };
        }
    }
}

