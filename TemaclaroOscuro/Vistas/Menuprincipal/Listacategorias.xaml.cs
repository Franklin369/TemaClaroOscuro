using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TemaClaroOscuro.VistaModelo;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TemaClaroOscuro.Vistas.Menuprincipal
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Listacategorias : ContentView
    {
        public Listacategorias()
        {
            InitializeComponent();
           // BindingContext = new VMpadreDashboard(Navigation);
        }
    }
}