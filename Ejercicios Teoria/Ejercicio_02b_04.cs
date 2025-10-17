/*Programa que le pide al usuario numero y los va sumando se detiene cuando detecta un numero negativo o 0 (no se suma)*/

using System;
public class Ejercicios
{
    static void Main()
    {
        int total = 0, num;
            do
            {
                Console.WriteLine("Introduce una cadena de numeros(los numeros negativos y el 0 no estan permitidos): ");
                num = Convert.ToInt32(Console.ReadLine());
                
                total =+ num;
                
            } while (num > 0 || num != 0);
            
            Console.WriteLine("La suma total es: " + total);
    }
    
}
