using Android.App;
using Android.OS;
using Android.Support.V7.App;
using Android.Runtime;
using Android.Widget;
using System;
using Android.Content;
using System.Net.Http;
using Android.Support.Design.Widget;

namespace App_standard.Droid
{
    [Activity(Label = "@string/app_name", Theme = "@style/AppTheme", MainLauncher = true)]
    public class MainActivity : Android.Support.V4.App.FragmentActivity
    {
        Android.Support.V7.Widget.Toolbar toolbar;
        Button cartButton;
        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.activity_main);  
            toolbar = (Android.Support.V7.Widget.Toolbar)FindViewById(Resource.Id.toolBar);
            toolbar.InflateMenu(Resource.Menu.optionMenu);
            toolbar.MenuItemClick += Toolbar_MenuItemClick;

            FragmentNavigate(new ItenFragment());

            cartButton = (Button)FindViewById(Resource.Id.cartButton);

            cartButton.Click += CartButton_Click;
        }

        private void Toolbar_MenuItemClick(object sender, Android.Support.V7.Widget.Toolbar.MenuItemClickEventArgs e)
        {
            if(e.Item.ItemId == Resource.Id.action_filter)
            {
                //implementar lista de filtros 
            } 
        }

        private void CartButton_Click(object sender, EventArgs e)
        {
            var intent = new Intent(this, typeof(CartActivity));
            StartActivity(intent);
        }

        private void FragmentNavigate(Android.Support.V4.App.Fragment fragment)
        {
            Android.Support.V4.App.FragmentTransaction transaction = SupportFragmentManager.BeginTransaction();
            transaction.Replace(Resource.Id.contentFrame, fragment);
            transaction.Commit();
        }
    }
}