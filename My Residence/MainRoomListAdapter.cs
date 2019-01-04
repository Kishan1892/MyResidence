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
    public class MainRoomListAdapter : BaseAdapter<MainRoom>
    {
        private readonly Activity context;
        List<MainRoom> mrData;

        public MainRoomListAdapter(Activity _context, List<MainRoom> _list)
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
        public override MainRoom this[int index]
        {
            get { return mrData[index]; }
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            var view = convertView;

            // re-use an existing view, if one is available otherwise create a new one
            if (view == null)
            {
                view = context.LayoutInflater.Inflate(Resource.Layout.MainRoomListItem, null, false);
            }

            MainRoom mr = this[position];


            if (String.IsNullOrEmpty(mr.Equipment_Name))
            {
                view.FindViewById<TextView>(Resource.Id.txtEquipName).Visibility = ViewStates.Gone;
            }
            else
            {
                view.FindViewById<TextView>(Resource.Id.txtEquipName).Text = mr.Equipment_Name;

            }


            if (String.IsNullOrEmpty(mr.Expiry_Date))
            {
                view.FindViewById<TextView>(Resource.Id.txtExpDate).Visibility = ViewStates.Gone;
            }
            else
            {
                view.FindViewById<TextView>(Resource.Id.txtExpDate).Text = mr.Expiry_Date;
            }


            if (String.IsNullOrEmpty(mr.Barcode))
            {
                view.FindViewById<TextView>(Resource.Id.txtBarcode).Visibility = ViewStates.Gone;
            }
            else
            {
                view.FindViewById<TextView>(Resource.Id.txtBarcode).Text = mr.Barcode;
            }

            if (String.IsNullOrEmpty(mr.Color))
            {
                view.FindViewById<TextView>(Resource.Id.txtColor).Visibility = ViewStates.Gone;
            }
            else
            {
                view.FindViewById<TextView>(Resource.Id.txtColor).Text = mr.Color;
            }



            return view;

        }



    }
}