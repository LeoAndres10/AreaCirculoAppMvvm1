using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaCirculoAppMvvm1.ViewModel
{
   public partial class AreaCirculoViewModel : ObservableObject

    {
        [ObservableProperty]
            private double d;

            [ObservableProperty]
            private double area;
            public AreaCirculoViewModel()
            {

            }

            private void Alerta(string Titulo, string Mensaje)
            {
                MainThread.BeginInvokeOnMainThread(async () => await App.Current!.MainPage!.DisplayAlert(Titulo, Mensaje, "Aceptar"));
            }

            [RelayCommand]

            private void Calcular()
            {
            try
            {
                double resultado;
                if (Validar())
                {

                    if (D == 0)
                    {
                       Alerta("ADVERTENCIA","El valor del diametro no puede ser igual a cero");
                    }

                    else
                    {
                        resultado = (Math.PI * (Math.Pow(D / 2, 2)));

                        Area = resultado;

                    }
                }
            }
            catch (Exception ex)
            {
                Alerta("ERROR", ex.Message);
              
            }
        }

     

        private bool Validar()
        {
            bool esValido = true;

            if (D == 0)
            {
                Alerta("ADVERTENCIA","Ingrese el diametro");
                esValido = false;
               
            }

            return esValido;
        }
       
    

            [RelayCommand]
            private void Limpiar()
            {
                D = 0;
                Area = 0;
            }

        }
    }

