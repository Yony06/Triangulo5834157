using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Triangulo5834157.Model
{
    partial class Area : ObservableObject
    {
        [ObservableProperty]
        public double n1;
        [ObservableProperty]
        public double n2;
        [ObservableProperty]
        public double n3;
        [ObservableProperty]
        public double s;
        [ObservableProperty]
        public string resultado;

        [RelayCommand]

        public void area()
        {
            if (double.TryParse(N1.ToString(), out double Lado1) && double.TryParse(N2.ToString(), out double Lado2) && double.TryParse(N3.ToString(), out double Lado3))
            {
                double S = (N1 + N2 + N3) / 2;

                double A = (S * (S - N1) * (S - N2) * (S - N3));
                double total = Math.Sqrt(A);
                Resultado = $"El area es : {total:F2} m2";

            }
        }
    }
}