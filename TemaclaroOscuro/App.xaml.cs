using System;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Plugin.SharedTransitions;
using TemaClaroOscuro.Vistas.Menuprincipal;

namespace TemaClaroOscuro
  {
  public partial class App : Application
    {
    public App()
      {
      InitializeComponent();

      MainPage=new SharedTransitionNavigationPage(new PadreDashboard());
      }

    protected override void OnStart()
      {
   
      }

    protected override void OnSleep()
      {
      }

    protected override void OnResume()
      {
      }
    }
  }
