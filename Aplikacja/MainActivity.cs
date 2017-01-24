using Android.App;
using Android.Widget;
using Android.OS;
using System.Collections.Generic;
using System;

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
            

            WidokListy adapter = new WidokListy(this, mprzedmiot);
            mwidoklisty.Adapter = adapter;
            mwidoklisty.ItemClick += mwidoklisty_klikniecie;
            mwidoklisty.ItemLongClick += mwidoklisty_lonk_klikniecie;
            mwidoklisty.ItemClick += mwidoklisty_klikniecie_2;
        }

        private void mwidoklisty_klikniecie_2(object sender, AdapterView.ItemClickEventArgs e)
        {
            Console.WriteLine("Krzysiek to najlepszy programista");

        }

        private void mwidoklisty_lonk_klikniecie(object sender, AdapterView.ItemLongClickEventArgs e)
        {
            Console.WriteLine(mprzedmiot[e.Position].nazwisko);
        }

        private void mwidoklisty_klikniecie(object sender, AdapterView.ItemClickEventArgs e)
        {
            Console.WriteLine(mprzedmiot[e.Position].imie);
        }
    }
}

