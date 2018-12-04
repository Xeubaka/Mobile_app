using System;
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
        List<Iten> itens;
        List<Promotion> promotions;
        string filtro = "Id";
        
        public override async void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
            // Create your fragment here
            itens = await Iten.GetItens();
            promotions = await Promotion.GetPromotions();
            ListAdapter = new ItenAdapter(Activity, itens, promotions);
        }

        public override void OnListItemClick(ListView l, View v, int position, long id)
        {
            base.OnListItemClick(l, v, position, id);

            var selectedIten = itens[position];

            Intent intent = new Intent(Activity, typeof(ItenActivity));
            intent.PutExtra("Name", selectedIten.Name);
            intent.PutExtra("Description", selectedIten.Description);
            intent.PutExtra("Photo", selectedIten.Photo);
            intent.PutExtra("Price", selectedIten.Price);
            intent.PutExtra("Category_id", selectedIten.Category_Id.Value);

            StartActivity(intent);
        }

        public void Filter()
        {
            switch (filtro)
            {
                case "Id":
                    itens.OrderByDescending(x => x.Id).ToList();
                    break;
                case "Name":
                    itens.OrderByDescending(x => x.Name).ToList();
                    break;
                case "Price":
                    itens.OrderByDescending(x => x.Price).ToList();
                    break;
            }

        }
    }
}