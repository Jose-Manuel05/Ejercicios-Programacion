/*Programa que le pide al usuario una contraseña hasta que sea correcta 111111*/

using System;
public class Ejercicio1
{
    static void Main()
    {
        Console.WriteLine("Introduce la contraseña: ");
        int cont = Convert.ToInt32(Console.ReadLine());

        while (cont != 1111)
        {
            Console.WriteLine("Escribe la contraseña: ");
            cont = Convert.ToInt32(Console.ReadLine());
        }
        Console.WriteLine("Contraseña correcta.");
    }
}
