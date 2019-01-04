using Android.App;
using Android.OS;
using Android.Views;
using Android.Widget;
using System.Collections.Generic;
using System;

namespace My_Residence
{
    public class MainRoomFragment: Fragment
    {

        protected ListView listView;
        protected List<MainRoom> mainRoom;

        public override void OnCreate(Bundle savedInstanceState)
        {
            base.OnCreate(savedInstanceState);
        }

        public override async void OnActivityCreated(Bundle savedInstanceState)
        {
            base.OnActivityCreated(savedInstanceState);
            listView = this.View.FindViewById<ListView>(Resource.Id.mainRoomListView);
            //DownloadListAsync();
            MainRoomDataService mrDataService = new MainRoomDataService();
            mainRoom = await mrDataService.getMainRoomListAsync();
            listView.Adapter = new MainRoomListAdapter(this.Activity, mainRoom);


        }

        //private async void DownloadListAsync()
        //{
        //    MainRoomDataService mrDataService = new MainRoomDataService();
        //    mainRoom = await mrDataService.getMainRoomListAsync();
        //    mrAdapter = new MainRoomListAdapter(this.Activity, mrListData);
        //}

        public override View OnCreateView(LayoutInflater inflater, ViewGroup container, Bundle savedInstanceState)
        {
            return inflater.Inflate(Resource.Layout.MainRoomFragmentView, container, false);
        }

    }
}