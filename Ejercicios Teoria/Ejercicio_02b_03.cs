/*Programa que le pide al usuario una contraseña hasta que sea correcta 1111 con DO WHILE*/

using System;
public class Ejercicios
{
    static void Main()
    {
        int pass;
        do
        {
            Console.WriteLine("Introduce la contraseña: ");
            pass = Convert.ToInt32(Console.ReadLine());
        }while (pass != 1111);
        
        Console.WriteLine("Contraseña correcta.");
    }
    
}
