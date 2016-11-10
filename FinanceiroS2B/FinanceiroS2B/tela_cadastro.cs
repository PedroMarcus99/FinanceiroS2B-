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

namespace FinanceiroS2B
{
    [Activity()]
    class tela_cadastro : Activity
    {
        protected override void OnCreate(Bundle bundle)
        {
            base.OnCreate(bundle);

            SetContentView(Resource.Layout.cadastro);
            this.ActionBar.SetDisplayHomeAsUpEnabled(true);
            FindViewById<Button>(Resource.Id.button1).Click += Tela_cadastro_Click; ;
        }

        private void Tela_cadastro_Click(object sender, EventArgs e)
        {
            string novoitem = FindViewById<EditText>(Resource.Id.editText1).Text;
            Intent resultIntent = new Intent(this, typeof(MainActivity));
            resultIntent.PutExtra("conta", novoitem);
            // TODO Add extras or a data URI to this intent as appropriate.
            SetResult(Result.Ok, resultIntent);
            Finish(); 
        }

        //Método que retorna para a tela inicial do projeto, quando a Activity de cadastro foi exibida. 
        public override bool OnOptionsItemSelected(IMenuItem item)
        {
            switch (item.ItemId)
            {

                case Android.Resource.Id.Home:
                    Finish();
                    return true;
                default:
                    return base.OnOptionsItemSelected(item);
            }
        }
    }
}