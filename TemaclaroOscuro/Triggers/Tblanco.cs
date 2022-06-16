using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
namespace TemaClaroOscuro.Triggers
  {
  public class Tblanco : TriggerAction<Image>
    {
    public bool Indicador { get; set; }
    uint tiempo = 250;
    int trasladarY = -250;
    Easing tipoanimacion = Easing.SpringOut;
    protected override async void Invoke(Image sender)
      {
      if(Indicador)
        {
        await sender.ScaleTo(1,250,Easing.BounceIn);
        await Task.WhenAll(
                       sender.TranslateTo(0,trasladarY,tiempo,tipoanimacion)
                       );
        sender.Source="luna_.png";
        await Task.WhenAll(

                     sender.TranslateTo(0,0,tiempo,tipoanimacion)
                     );
        }
      else
        {
        // sender.TranslationY = new Image().TranslationY

        await Task.WhenAll(
            sender.FadeTo(1,tiempo,Easing.SinIn),
                       sender.TranslateTo(0,trasladarY,tiempo,tipoanimacion)
                       );
        sender.Source="dom.png";

        await Task.WhenAll(

                       sender.TranslateTo(0,0,tiempo,tipoanimacion)
                       );
        }


      }
    }
  }
