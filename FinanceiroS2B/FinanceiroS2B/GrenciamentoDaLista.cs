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
using System.Linq;

namespace FinanceiroS2B
{
   public class GrenciamentoDaLista : BaseAdapter<string>
    {
        List<string> CONTAS;
        Activity C;
        //private MainActivity mainActivity;

        public GrenciamentoDaLista(List<string> dados, Activity c)
        {
            CONTAS = dados;
            C = c;
        }

        public override int Count
        {
            get
            {
                //throw new NotImplementedException();
                return CONTAS.Count;
            }
        }

        public override string this[int position]
        {
            get
            {
                // throw new NotImplementedException();
                return CONTAS[position];
            }
        }

       // public void GerenciamentoLista(List<string> dados, Activity c)
       // {
          
      //  }

        public override long GetItemId(int position)
        {
            //throw new NotImplementedException();
            return position; 
        }

        public override View GetView(int position, View convertView, ViewGroup parent)
        {
            // throw new NotImplementedException();
            View view = convertView;
            if (view == null)
                view = C.LayoutInflater.Inflate(Resource.Layout.DadosConta, null);
            view.FindViewById<TextView>(Resource.Id.textLabel).Text = CONTAS[position];
            return view; 
            

                     

        }
    }
}