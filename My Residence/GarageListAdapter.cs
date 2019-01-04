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
    public class GarageListAdapter : BaseAdapter<Garage>
    {
        private readonly Activity context;
        List<Garage> mrData;

        public GarageListAdapter(Activity _context, List<Garage> _list)
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
        public override Garage this[int index]
        {
            get { return mrData[index]; }
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            var view = convertView;

            // re-use an existing view, if one is available otherwise create a new one
            if (view == null)
            {
                view = context.LayoutInflater.Inflate(Resource.Layout.GarageListItem, null, false);
            }

            Garage ge = this[position];


            if (String.IsNullOrEmpty(ge.Equipment_Name))
            {
                view.FindViewById<TextView>(Resource.Id.txtEquipName2).Visibility = ViewStates.Gone;
            }
            else
            {
                view.FindViewById<TextView>(Resource.Id.txtEquipName2).Text = ge.Equipment_Name;

            }


            if (String.IsNullOrEmpty(ge.Expiry_Date))
            {
                view.FindViewById<TextView>(Resource.Id.txtExpDate2).Visibility = ViewStates.Gone;
            }
            else
            {
                view.FindViewById<TextView>(Resource.Id.txtExpDate2).Text = ge.Expiry_Date;
            }


            if (String.IsNullOrEmpty(ge.Barcode))
            {
                view.FindViewById<TextView>(Resource.Id.txtBarcode2).Visibility = ViewStates.Gone;
            }
            else
            {
                view.FindViewById<TextView>(Resource.Id.txtBarcode2).Text = ge.Barcode;
            }

            if (String.IsNullOrEmpty(ge.Color))
            {
                view.FindViewById<TextView>(Resource.Id.txtColor2).Visibility = ViewStates.Gone;
            }
            else
            {
                view.FindViewById<TextView>(Resource.Id.txtColor2).Text = ge.Color;
            }



            return view;

        }
    }
}