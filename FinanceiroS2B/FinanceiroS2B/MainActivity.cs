﻿using System;
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
using FinanceiroS2B;

namespace FinanceiroS2B
{
    [Activity(Label = "FinanceiroS2B", MainLauncher = true, Icon = "@drawable/icon")]
    public class MainActivity : Activity
    {
        public List<String> CONTAS; 
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            // Set our view from the "main" layout resource
            SetContentView(Resource.Layout.Main);

            // Get our button from the layout resource,
            // and attach an event to it
            // Button botao_cadastro = FindViewById<Button>(Resource.Id.MyButton);

            
            FindViewById<Button>(Resource.Id.MyButton).Click += Novaconta;
            FindViewById<TextView>(Resource.Id.textView1).Click += MainActivity_Click;

            CONTAS = new List<string>();
            CONTAS.Add("Bradesco");
            CONTAS.Add("Carteira");
            CONTAS.Add("Caixa");
            CONTAS.Add("Banco do Brasil");

            //string novoitem;
            //novoitem = FindViewById<EditText>(Resource.Id.editText1).Text;
            //CONTAS.Add(novoitem);

            ListView Lista = FindViewById<ListView>(Resource.Id.listaDados);

            GrenciamentoDaLista GL = new GrenciamentoDaLista(CONTAS, this);

            Lista.Adapter = GL;
            Lista.ItemClick += List_ItemClick;      
           

        }
      

        void List_ItemClick(object sender, AdapterView.ItemClickEventArgs e)
        {
            Toast.MakeText(this, CONTAS[e.Position], ToastLength.Short).Show();
        }

        void Novaconta(object sender, EventArgs e)
        {
            // nova pagina
            //StartActivity(typeof(tela_cadastro));
            var myIntent = new Intent(this, typeof(tela_cadastro));
            StartActivityForResult(myIntent, 0);
        }
        void MainActivity_Click(object sender, EventArgs e)
        { StartActivity(typeof(Contas)); }

        protected override void OnActivityResult(int requestCode, Result resultCode, Intent data)
        {
            if (resultCode == Result.Ok)
            {
                CONTAS.Add(data.GetStringExtra("conta"));
            }
            // do what you want with the result here
        }
    }
}

