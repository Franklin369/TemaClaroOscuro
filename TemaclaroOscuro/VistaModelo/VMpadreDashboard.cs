using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using TemaClaroOscuro.Datos;
using TemaClaroOscuro.Modelo;
using TemaClaroOscuro.Vistas;
using System.Collections.ObjectModel;

namespace TemaClaroOscuro.VistaModelo
  {
  public class VMpadreDashboard : BaseViewModel
    {
    #region VARIABLES
    string _Texto;
    ObservableCollection<Mcategorias> _listacategorias;
    ObservableCollection<Mmovimientos> _listamov;
    #endregion
    #region CONSTRUCTOR
    public VMpadreDashboard(INavigation navigation)
      {
      Navigation=navigation;
      Mostrarcategorias();
      Mostrarmov();
      }
    #endregion
    #region OBJETOS
    public ObservableCollection<Mcategorias> Listacategorias
      {
      get { return _listacategorias; }
      set { SetValue(ref _listacategorias,value); }
      }
    public ObservableCollection<Mmovimientos> Listamov
      {
      get { return _listamov; }
      set { SetValue(ref _listamov,value); }
      }
    #endregion
    #region PROCESOS
    public async void Volver()
      {
      await Navigation.PopAsync();
      }
    public void Mostrarcategorias()
      {
      Listacategorias=new ObservableCollection<Mcategorias>(Dlista.Mostrarcategorias());
      }
    public void Mostrarmov()
      {
      Listamov=new ObservableCollection<Mmovimientos>(Dlista.Mostarmov());
      }
    private async void Cambiartema()
      {
      await Navigation.PushAsync(new CambiosTema());
      }
    #endregion
    #region COMANDOS
    public ICommand Cambiartemacommand => new Command(Cambiartema);
    #endregion
    }
  }
