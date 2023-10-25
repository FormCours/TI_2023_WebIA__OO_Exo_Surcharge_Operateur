using ConverteurFC.Modèles;


Celsius c1= new Celsius();
c1.Temperature = 0.1;
Console.WriteLine($" Etape 1 : Ceci est une temperature en {c1.TemperatureAvecUnite}");

Fahrenheit f1 = c1.ToFahrenheit();
Console.WriteLine($" Etape 2 : Ceci est une temperature en {f1.TemperatureAvecUnite}");

Celsius c2 = f1.ToCelsius();
Console.WriteLine($" Etape 3 : Ceci est une temperature en {c2.TemperatureAvecUnite}");


Celsius c3 = (Celsius)f1;
Fahrenheit f3 = c3;
