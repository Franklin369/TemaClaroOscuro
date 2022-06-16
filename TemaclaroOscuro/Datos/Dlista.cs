using System.Collections.Generic;
using TemaClaroOscuro.Modelo;
using System.Threading.Tasks;
using System.Linq;
using Xamarin.Forms;
using System;
using System.Collections.ObjectModel;
namespace TemaClaroOscuro.Datos
{
    public class Dlista
    {
 
        public static ObservableCollection<Mcategorias> Mostrarcategorias()
        {
            return new ObservableCollection<Mcategorias>()
            {
              new Mcategorias()
              {
                  Categoria="Bebidas",
                  Icono="q1.png",
                  Color="#02CAFE"
              },
               new Mcategorias()
              {
                  Categoria="Comida",
                  Icono="q2.png",
                  Color="#FF009D"
              },
                new Mcategorias()
              {
                  Categoria="Deportes",
                  Icono="q3.png",
                  Color="#9B43D8"
              },
                 new Mcategorias()
              {
                  Categoria="Juegos",
                  Icono="hojas.png",
                  Color="#FFF288"
              },

            };
        }
        public static ObservableCollection<Mmovimientos> Mostarmov()
        {
            return new ObservableCollection<Mmovimientos>()
            {
              new Mmovimientos()
              {
                  Nombre="shared",
                  Foto="q1.png",
                  Hora="14:45 pm",
                  Monto="$ 9.36",
                  Color="#FFF288"
              },
              new Mmovimientos()
              {
                  Nombre="shared",
                  Foto="q2.png",
                  Hora="14:45 pm",
                  Monto="$ 9.36",
                  Color="#FE6544"
              },
            
              new Mmovimientos()
              {
                  Nombre="shared",
                  Foto="q3.png",
                  Hora="14:45 pm",
                  Monto="$ 9.36",
                  Color="#8EDF78"
              },
              new Mmovimientos()
              {
                  Nombre="shared",
                  Foto="helado.png",
                  Hora="14:45 pm",
                  Monto="$ 9.36",
                  Color="#FF3B32"
              },
             new Mmovimientos()
              {
                  Nombre="shared",
                  Foto="hojas.png",
                  Hora="14:45 pm",
                  Monto="$ 9.36",
                  Color="#8EDF78"
              },
             new Mmovimientos()
              {
                  Nombre="shared",
                  Foto="luna_.png",
                  Hora="14:45 pm",
                  Monto="$ 9.36",
                  Color="#8EDF78"
              },
            };
        }
    }
}
