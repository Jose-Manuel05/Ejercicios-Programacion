// Este programa solicita al usuario el número de prácticas realizadas y sus respectivas notas.
using System;

public class Ejercicio
{
    static void Main()
    {
        int numeroPracticas = 0;
        double notaPractica = 0,
            sumaNotasPracticas = 0,
            mediaPracticas = 0,
            notaExamen = 0,
            notaFinal = 0;
        bool algunaPracticaSuspensa = false;

        // Pedir número prácticas
        Console.Write("Introduce el número de prácticas realizadas: ");
        bool numeroCorrecto = false;

        while (!numeroCorrecto)
        {
            try
            {
                numeroPracticas = Convert.ToInt32(Console.ReadLine());

                if (numeroPracticas > 0)
                {
                    numeroCorrecto = true;
                }
                else
                {
                    Console.WriteLine("Error: Debes introducir un número entero positivo.");
                }
            }
            catch
            {
                Console.WriteLine("Error: Debes escribir un número válido.");
            }

            if (!numeroCorrecto)
            {
                Console.Write("Introduce el número de prácticas realizadas: ");
            }
        }

        // Pedir notas practicas
        for (int i = 1; i <= numeroPracticas; i++)
        {
            bool notaValida = false;

            while (!notaValida)
            {
                Console.Write("Introduce la nota de la práctica nº{i} (0-10): ");
                string entrada = Console.ReadLine();
                entrada = entrada.Replace(',', '.'); // acepta coma o punto

                try
                {
                    notaPractica = Convert.ToDouble(entrada);

                    if (notaPractica >= 0 && notaPractica <= 10)
                    {
                        notaValida = true;
                    }
                    else
                    {
                        Console.WriteLine("Error: La nota debe estar entre 0 y 10.");
                    }
                }
                catch
                {
                    Console.WriteLine("Error: Introduce un número válido.");
                }
            }

            sumaNotasPracticas += notaPractica;

            if (notaPractica < 3)
            {
                algunaPracticaSuspensa = true;
            }
        }

        mediaPracticas = sumaNotasPracticas / numeroPracticas;
        Console.WriteLine("Media de prácticas: " + mediaPracticas);

        // Pedir nota examen
        bool examenValido = false;
        Console.Write("Introduce la nota del examen final (0-10): ");

        while (!examenValido)
        {
            string entradaExamen = Console.ReadLine();
            entradaExamen = entradaExamen.Replace(',', '.');

            try
            {
                notaExamen = Convert.ToDouble(entradaExamen);

                if (notaExamen >= 0 && notaExamen <= 10)
                {
                    examenValido = true;
                }
                else
                {
                    Console.WriteLine("Error: La nota debe estar entre 0 y 10.");
                    Console.Write("Introduce la nota del examen final (0-10): ");
                }
            }
            catch
            {
                Console.WriteLine("Error: Introduce un número válido.");
                Console.Write("Introduce la nota del examen final (0-10): ");
            }
        }

        Console.WriteLine("Nota del examen: " + notaExamen);

        // Calcular nota
        notaFinal = mediaPracticas * 0.3 + notaExamen * 0.7;

        if (notaExamen < 4 || mediaPracticas < 5 || algunaPracticaSuspensa)
        {
            notaFinal = Math.Min(notaFinal, 4);
        }

        notaFinal = Math.Round(notaFinal, 2);
        Console.WriteLine("Tu nota final es: " + notaFinal);
    }
}

