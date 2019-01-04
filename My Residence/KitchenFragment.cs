using Android.App;
using Android.OS;
using Android.Views;
using Android.Widget;
using System.Collections.Generic;

namespace My_Residence
{
    public class KitchenFragment : Fragment
    {
        protected ListView listView;
        protected List<Kitchen> kitchen;

        public override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
        }

        public override async void OnActivityCreated(Bundle savedInstanceState)
        {
            base.OnActivityCreated(savedInstanceState);
            listView = this.View.FindViewById<ListView>(Resource.Id.kitchenListView);
            //DownloadListAsync();
            KitchenDataService krDataService = new KitchenDataService();
            kitchen = await krDataService.getMainRoomListAsync();
            listView.Adapter = new KitchenListAdapter(this.Activity, kitchen);


        }

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            return inflater.Inflate(Resource.Layout.KitchenFragmentView, container, false);
        }
    }
}