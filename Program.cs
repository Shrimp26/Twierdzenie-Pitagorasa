using System;

class Program{
//Zaimplementuj twierdzenie Pitagorasa a^2+b^2=c^2. Oblicz długość przeciwprostokątnej trójkąta prostokątnego o przyprostokątnych a = 3.5 i b = 6. Wynik obliczeń wyświetl w konsoli.
    static void Main()
    {
        double a = 3.5;
        double b = 6;
        double c = CalculateHypotenause(a, b);

        Console.WriteLine($"Długość przeciwprostokątnej c = ; {c}");
    }

    static double
        CalculateHypotenause (double a, double b)
    {
        return Math.Sqrt(Math.Pow(a, 2) + Math.Pow(b, 2));
    }
}