using Android.App;
using Android.Widget;
using Android.OS;
using System.Collections.Generic;

namespace Aplikacja
{
    [Activity(Label = "Aplikacja", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {

        private List<osoba1> mprzedmiot;
        private ListView mwidoklisty;
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            SetContentView(Resource.Layout.Main);
            mwidoklisty = FindViewById<ListView>(Resource.Id.listanr1);
            // Set our view from the "main" layout resource

            mprzedmiot = new List<osoba1>();

            mprzedmiot.Add(new osoba1() { imie = "krzysiek", nazwisko = "pławski", plec = "facet", wiek = "22" });
            mprzedmiot.Add(new osoba1() { imie = "piotr", nazwisko = "kolasinski", plec = "facet", wiek = "22" });
            mprzedmiot.Add(new osoba1() { imie = "waclaw", nazwisko = "kowalski", plec = "facet", wiek = "22" });
            mprzedmiot.Add(new osoba1() { imie = "daniel", nazwisko = "dudkowski", plec = "shemale", wiek = "12" });
            /*
            mprzedmiot.Add("Norbert");
            mprzedmiot.Add("Kolasinski");
            mprzedmiot.Add("Czarek");
            mprzedmiot.Add("Wawer");
            mprzedmiot.Add("Adam");
            */

            WidokListy adapter = new WidokListy(this, mprzedmiot);
            mwidoklisty.Adapter = adapter;
        }
    }
}

