using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ConverteurFC.Modèles
{
    public struct Celsius
    {
        public double Temperature { get; set;}

        

        public Fahrenheit ToFahrenheit()
        {
            Fahrenheit fahrenheit = new Fahrenheit();
            fahrenheit.Temperature = Math.Round((Temperature * 9 / 5) + 32, 3);
            return fahrenheit;
        }

        public string TemperatureAvecUnite
        {
            get
            {
                return Temperature + "°C";
            }

        }

        public static explicit operator Celsius(Fahrenheit temp)
        {
            return temp.ToCelsius();
        }
    }
}
