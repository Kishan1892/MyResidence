using Android.App;
using Android.Widget;
using Android.OS;
using Android.Views;
using System.Collections.Generic;

namespace My_Residence
{
    public class GarageFragment : Fragment
    {
        protected ListView listView;
        protected List<Garage> garage;

        public override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
        }

        public override async void OnActivityCreated(Bundle savedInstanceState)
        {
            base.OnActivityCreated(savedInstanceState);
            listView = this.View.FindViewById<ListView>(Resource.Id.garageListView);
            //DownloadListAsync();
            GarageDataService geDataService = new GarageDataService();
            garage = await geDataService.getMainRoomListAsync();
            listView.Adapter = new GarageListAdapter(this.Activity, garage);


        }

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            return inflater.Inflate(Resource.Layout.GarageFragmentView, container, false);
        }
    }
}
