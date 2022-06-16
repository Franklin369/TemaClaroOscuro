using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using TemaClaroOscuro.VistaModelo;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TemaClaroOscuro.Vistas
  {
  [XamlCompilation(XamlCompilationOptions.Compile)]
  public partial class CambiosTema : ContentPage
    {
    public CambiosTema()
      {
      InitializeComponent();
      BindingContext=new VMcambiotema(Navigation);
      }
    }
  }