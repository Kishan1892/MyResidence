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
    public class MainRoom
    {
        public string Equipment_Name { get; set; }
        public string Expiry_Date { get; set; }
        public string Barcode { get; set; }
        public string Color { get; set; }
    }
}