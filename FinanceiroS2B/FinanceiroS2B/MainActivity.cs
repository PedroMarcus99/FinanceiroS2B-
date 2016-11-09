using System;
using Android.App;
using Android.Content;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Android.OS;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Android.Locations;

namespace FinanceiroS2B
{
    [Activity(Label = "FinanceiroS2B", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {

        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            // Get our button from the layout resource,
            // and attach an event to it
           // Button botao_cadastro = FindViewById<Button>(Resource.Id.MyButton);

            FindViewById<Button>(Resource.Id.MyButton).Click += Novaconta;

            }

       void Novaconta(object sender, EventArgs e)
        {
           // nova pagina
            StartActivity(typeof(tela_cadastro));
        }
    }
}

