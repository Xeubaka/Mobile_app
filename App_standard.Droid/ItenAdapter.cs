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

namespace App_standard.Droid
{
    class ItenAdapter : BaseAdapter
    {

        Context context;
        List<Iten> Itens;

        public ItenAdapter(Activity activity, Context context, List<Iten> Itens)
        {
            this.context = context;
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
                var inflater = context.GetSystemService(Context.LayoutInflaterService).JavaCast<LayoutInflater>();
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

                view.Tag = holder;
            }


            //fill in your items
            var Itens = Itens[position];
            //holder.imageIten = Itens.imageIten;
            holder.nameIten.Text = Itens.nameIten;
            holder.promotionIten.Text = Itens.promotionIten;
            holder.priceIten.Text = Itens.priceIten;
            //default:
            holder.checkBoxIten.Checked = false;
            holder.quantidadeIten.Text = "0";

            return view;
        }

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