using System.Runtime.Intrinsics.Arm;

double temperaturaCelsjusz = 25;
double temperaturaFahrenheit = (temperaturaCelsjusz * 9 / 5) + 32;

temperaturaCelsjusz = (temperaturaFahrenheit - 32) * 5 / 9;

if(temperaturaCelsjusz < 0)
    {
    Console.WriteLine("Temperatura poniżej zera!");
}

Console.WriteLine($"Temperatura w Celsjuszach: {Math.Round(temperaturaCelsjusz, 2)}°C");
Console.WriteLine($"Temperatura w Fahrenheitach: {Math.Round(temperaturaFahrenheit, 2)}°F");

