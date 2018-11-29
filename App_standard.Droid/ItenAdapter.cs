using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.Graphics;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Com.Bumptech.Glide;
using Com.Bumptech.Glide.Load.Engine;
using Java.IO;
using Java.Net;

namespace App_standard.Droid
{
    class ItenAdapter : BaseAdapter
    {

        Context Context;
        List<Iten> Itens;
        List<Promotion> Promotions;

        public ItenAdapter(Context context,List<Iten> itens, List<Promotion> promotions)
        {
            Context = context;
            Itens = itens;
            Promotions = promotions;
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
            var view = convertView;
            ItenAdapterViewHolder holder = null;

            if (view != null)
                holder = view.Tag as ItenAdapterViewHolder;

            if (holder == null)
            {
                holder = new ItenAdapterViewHolder();
                var inflater = Context.GetSystemService(Context.LayoutInflaterService).JavaCast<LayoutInflater>();
                //replace with your item and your holder items
                //comment back in

                view = inflater.Inflate(Resource.Layout.Iten, parent, false);

                holder.imageIten = view.FindViewById<ImageView>(Resource.Id.imageIten);
                holder.nameIten = view.FindViewById<TextView>(Resource.Id.nameIten);
                holder.checkBoxIten = view.FindViewById<CheckBox>(Resource.Id.checkBoxIten);
                holder.promotionIten = view.FindViewById<TextView>(Resource.Id.promotionIten);
                holder.quantidadeIten = view.FindViewById<TextView>(Resource.Id.quantidadeIten);
                holder.priceIten = view.FindViewById<TextView>(Resource.Id.priceIten);
                holder.btn_less = view.FindViewById<Button>(Resource.Id.btn_less);
                holder.btn_plus = view.FindViewById<Button>(Resource.Id.btn_plus);

                //holder.btn_less.Click += Btn_Click;
                //holder.btn_plus.Click += Btn_Click;

                view.Tag = holder;
            }


            //fill in your items
            var Iten = Itens[position];
            Iten.btn_less_id = holder.btn_less.Id;
            Iten.btn_plus_id = holder.btn_plus.Id;
            if(Iten != null)
            {
                //implementar get imagem url
            }
            holder.nameIten.Text = Iten.Name;
            foreach (var promo in Promotions)
            {
                if(promo.Category_id == Iten.Category_Id)
                {
                    //holder.promotionIten.Text = "" + promo.Polices.ToString();
                    holder.promotionIten.Text = "" + promo.ToString();
                }
                
            }
            //holder.promotionIten.Text = promotion.policies;
            holder.priceIten.Text = ""+Iten.Price;
            //default:
            holder.checkBoxIten.Checked = false;
            holder.quantidadeIten.Text = ""+Iten.Quantidade;

            return view;
        }

        /*
        private void Btn_Click(object sender, EventArgs e)
        {
            Iten.Button_OnClick(e);
        }
        */
        //Fill in cound here, currently 0
        public override int Count => Itens.Count;

    }

    class ItenAdapterViewHolder : Java.Lang.Object
    {
        //Your adapter views to re-use
        public ImageView imageIten { get; set; }
        public TextView nameIten { get; set; }
        public CheckBox checkBoxIten { get; set; }
        public TextView promotionIten { get; set; }
        public TextView quantidadeIten { get; set; }
        public TextView priceIten { get; set; }
        public Button btn_less { get; set; }
        public Button btn_plus { get; set; }

    }
}
