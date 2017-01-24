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

namespace Aplikacja
{
    class WidokListy : BaseAdapter<osoba1>
    {
        private List<osoba1> mprzedmiot;
        private Context mkontener;
        public WidokListy(Context context, List<osoba1> items)
        {
            mprzedmiot = items;
            mkontener = context;
        }
        public override int Count
        {
           
            get
            {
                return mprzedmiot.Count;
            }
        }
        public override long GetItemId(int position)
        {
            return position;
        }
        public override osoba1 this[int position]
        {

            get
            {
                return mprzedmiot[position];
            }
        }
        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            View row = convertView;
            if (row == null)
            {
                row = LayoutInflater.From(mkontener).Inflate(Resource.Layout.ListView, null, false);
            }
            TextView txtname = row.FindViewById<TextView>(Resource.Id.txtname);
            txtname.Text = mprzedmiot[position].imie;
            TextView txtLastName = row.FindViewById<TextView>(Resource.Id.txtLastName);
            txtLastName.Text = mprzedmiot[position].nazwisko;
            TextView txtAge = row.FindViewById<TextView>(Resource.Id.txtAge);
            txtAge.Text = mprzedmiot[position].wiek;
            TextView txtGender = row.FindViewById<TextView>(Resource.Id.txtGender);
            txtGender.Text = mprzedmiot[position].plec;
            return row;
        }
      
    }

}