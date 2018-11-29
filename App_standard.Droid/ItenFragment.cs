﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Util;
using Android.Views;
using Android.Widget;

namespace App_standard.Droid
{
    public class ItenFragment : Android.Support.V4.App.ListFragment
    {
        public override async void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);

            // Create your fragment here
            List<Iten> itens = await Iten.GetItens();
            List<Promotion> promotions = await Promotion.GetPromotions();
            ListAdapter = new ItenAdapter(Activity, itens, promotions);
        }

    }
}