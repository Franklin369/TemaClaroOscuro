using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TemaClaroOscuro.Temas
  {
  [XamlCompilation(XamlCompilationOptions.Compile)]
  public partial class Temaoscuro : ResourceDictionary
    {
    public Temaoscuro()
      {
      InitializeComponent();
      }
    }
  }