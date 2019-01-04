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

namespace My_Residence
{
    public class KitchenListAdapter : BaseAdapter<Kitchen>
    {
        private readonly Activity context;
        List<Kitchen> mrData;

        public KitchenListAdapter(Activity _context, List<Kitchen> _list)
            : base()
        {
            this.context = _context;
            this.mrData = _list;
        }


        public override int Count
        {
            get { return mrData.Count; }
        }

        public override long GetItemId(int position)
        {
            return position;
        }
        public override Kitchen this[int index]
        {
            get { return mrData[index]; }
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            var view = convertView;

            // re-use an existing view, if one is available otherwise create a new one
            if (view == null)
            {
                view = context.LayoutInflater.Inflate(Resource.Layout.KitchenListItem, null, false);
            }

            Kitchen kn = this[position];


            if (String.IsNullOrEmpty(kn.Equipment_Name))
            {
                view.FindViewById<TextView>(Resource.Id.txtEquipName1).Visibility = ViewStates.Gone;
            }
            else
            {
                view.FindViewById<TextView>(Resource.Id.txtEquipName1).Text = kn.Equipment_Name;

            }


            if (String.IsNullOrEmpty(kn.Expiry_Date))
            {
                view.FindViewById<TextView>(Resource.Id.txtExpDate1).Visibility = ViewStates.Gone;
            }
            else
            {
                view.FindViewById<TextView>(Resource.Id.txtExpDate1).Text = kn.Expiry_Date;
            }


            if (String.IsNullOrEmpty(kn.Barcode))
            {
                view.FindViewById<TextView>(Resource.Id.txtBarcode1).Visibility = ViewStates.Gone;
            }
            else
            {
                view.FindViewById<TextView>(Resource.Id.txtBarcode1).Text = kn.Barcode;
            }

            if (String.IsNullOrEmpty(kn.Color))
            {
                view.FindViewById<TextView>(Resource.Id.txtColor1).Visibility = ViewStates.Gone;
            }
            else
            {
                view.FindViewById<TextView>(Resource.Id.txtColor1).Text = kn.Color;
            }



            return view;

        }
    }
}