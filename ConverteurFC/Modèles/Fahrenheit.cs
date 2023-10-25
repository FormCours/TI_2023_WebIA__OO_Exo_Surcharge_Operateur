using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConverteurFC.Modèles
{
     public struct Fahrenheit
    {
        public double Temperature { get; set; }

        public Celsius ToCelsius()
        {
            Celsius celsius = new Celsius();
            celsius.Temperature = Math.Round((Temperature - 32) * 5/9, 3);
            return celsius;
        }

        public string TemperatureAvecUnite
        { get
            {
                return Temperature + "°F";
            }

        }

        public static implicit operator Fahrenheit(Celsius temp)
        {
            return temp.ToFahrenheit();
        }
    }
}
