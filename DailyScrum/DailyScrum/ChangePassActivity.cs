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
    [Activity(Label = "ChangePassActivity")]
    public class ChangePassActivity : Activity
    {
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            SetContentView(Resource.Layout.ChangePass);

            string Username = Intent.GetStringExtra("Username");
            var PreviousPass = FindViewById<EditText>(Resource.Id.editText1);
            var NewPass = FindViewById<EditText>(Resource.Id.editText2);
            var Confirm = FindViewById<EditText>(Resource.Id.editText3);

            FindViewById<Button>(Resource.Id.button1).Click += delegate
            {

                UsersReference.Users users = new UsersReference.Users();
                bool login_result = false;
                bool defined = true;
                users.Login(Username, PreviousPass.Text, out login_result, out defined);
                if (!login_result)
                {
                    Toast.MakeText(this, "Previous password is invalid", ToastLength.Long).Show();
                    return;
                }

                if (NewPass.Text != Confirm.Text)
                {
                    Toast.MakeText(this, "Password and it's confirm didn't match", ToastLength.Long).Show();
                    return;
                }

                users.ChangePass(Username, NewPass.Text);
                Toast.MakeText(this, "Done!", ToastLength.Long).Show();
                Finish();
            };
        }
    }
}