/* Programa que solicita una unidad de temperatura (C, F o K) y una temperatura numérica.
Convierte la temperatura a grados Celsius si es necesario y muestra un mensaje
indicando si hace frío, buen tiempo o calor según el valor en Celsius.*/

using System;
public class Practica_1_1
{
    static void Main()
    {
        Console.WriteLine("Dime una unidad de temperatura: ");
        char unidad = char.Parse(Console.ReadLine());

        if (unidad != 'C' && unidad != 'F' && unidad != 'K')
        {
            Console.WriteLine("Unidad incorrecta");
        }
        
        Console.Write("Dime una temperatura en esa unidad (" + unidad + "): ");
        int temp = int.Parse(Console.ReadLine());

        double cel = 0;

        switch (unidad)
        {
            case 'C':
                cel = temp;
                break;
            case 'F':
                cel = (temp -32) / 2;
                Console.WriteLine(temp + " en Fahrenheit son " + cel + " Celsius");
                break;
            case 'K':
                cel = temp - 273;
                Console.WriteLine(temp + " en Kelvin son " + cel + " Celsius");
                break;
        }

        if (cel < 10)
        {
            Console.WriteLine("Hace frío");
        }
        else if (cel <= 20)
        {
            Console.WriteLine("Hace buen tiempo");
        }
        else
        {
            Console.WriteLine("Hace calor");
        }

    }
}
