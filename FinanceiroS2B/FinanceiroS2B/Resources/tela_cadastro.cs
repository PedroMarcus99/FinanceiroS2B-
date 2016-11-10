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

namespace FinanceiroS2B {
    [Activity()]
    class tela_cadastro : Activity {

        protected override void OnCreate(Bundle bundle) {//cria a nova tela 
            base.OnCreate(bundle);

            SetContentView(Resource.Layout.cadastro);
            this.ActionBar.SetDisplayHomeAsUpEnabled(true);

            }

        public override bool OnOptionsItemSelected(IMenuItem item)///volta na tela 
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