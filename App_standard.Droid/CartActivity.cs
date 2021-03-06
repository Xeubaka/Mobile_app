﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;

namespace App_standard.Droid
{
    [Activity(Label = "CartActivity")]
    public class CartActivity : Activity
    {
        Android.Support.V7.Widget.Toolbar toolbar;
        Button cartCheckOutButton;

        protected override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your application here
            SetContentView(Resource.Layout.CartCheckOut);
            cartCheckOutButton = (Button)FindViewById(Resource.Id.cartCheckOutButton);
            cartCheckOutButton.Click += CartCheckOutButton_Click;
            toolbar = (Android.Support.V7.Widget.Toolbar)FindViewById(Resource.Id.toolBarCart);
            toolbar.Click += Toolbar_Click;
            toolbar.SetNavigationIcon(Android.Resource.Drawable.IcMenuRevert);
            toolbar.SetBackgroundColor(Android.Graphics.Color.LightBlue);
        }

        private void CartCheckOutButton_Click(object sender, EventArgs e)
        {
            Toast.MakeText(this, "Finalizando compra!", ToastLength.Long).Show();
        }

        private void Toolbar_Click(object sender, EventArgs e)
        {
            OnBackPressed();
        }

    }
}