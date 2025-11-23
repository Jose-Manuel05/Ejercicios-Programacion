/*
 *Programa que solicita al usuario un numero para definir la altura de una figura,
 seguido de un caracter para rellenar dicha figura
 */

using System;

public class Practica_2_1
{
    static void Main()
    {

        Console.Write("Introduce la altura de la figura: ");
        int altura = int.Parse(Console.ReadLine());

        Console.Write("Introduce el carácter de relleno: ");
        char simbolo = Console.ReadKey().KeyChar;
        Console.WriteLine();

        // Dibujar la figura
        for (int i = 1; i <= altura; i++)
        {
            // Parte izquierda
            for (int j = 0; j < i; j++)
            {
                Console.Write(simbolo);
            }

            // Espacios centrales
            int espacios = (altura - i) * 2;
            for (int j = 0; j < espacios; j++)
            {
                Console.Write(" ");
            }

            // Parte derecha
            for (int j = 0; j < i; j++)
            {
                Console.Write(simbolo);
            }

            Console.WriteLine();
        }

    }
}
