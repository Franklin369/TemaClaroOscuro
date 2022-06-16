using Plugin.SharedTransitions;
using System.Windows.Input;
using TemaClaroOscuro.Vistas.Menuprincipal;
using Xamarin.Forms;
namespace TemaClaroOscuro.VistaModelo
  {
  public class VMcambiotema : BaseViewModel
    {
    #region VARIABLES 
    #endregion
    #region CONSTRUCTOR
    public VMcambiotema(INavigation navigation)
      {
      Navigation=navigation;
      }
    #endregion
    #region OBJETOS
   
   
    #endregion
    #region PROCESOS
    public async void Verresultados()
      {
      var page = (App.Current.MainPage as SharedTransitionNavigationPage).CurrentPage;
      SharedTransitionNavigationPage.SetBackgroundAnimation(page,BackgroundAnimation.SlideFromBottom);
      SharedTransitionNavigationPage.SetTransitionDuration(page,500);
      await Navigation.PushAsync(new PadreDashboard());
      }
  
    #endregion
    #region COMANDOS
    public ICommand Verresultadoscommand => new Command(Verresultados);
    #endregion
    }
  }
