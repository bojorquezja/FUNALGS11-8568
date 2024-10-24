using System;



class Program

{

    static void Main()

    {

        Console.Write("¿Cuántos elementos deseas en el arreglo?: ");

        int n = int.Parse(Console.ReadLine());



        int[] arreglo = new int[n];

        Random random = new Random();



        Console.WriteLine("\nArreglo generado:");

        for (int i = 0; i < n; i++)

        {

            arreglo[i] = random.Next(50, 91); 

            Console.Write(arreglo[i] + " ");

        }


        Console.WriteLine("\n\n¿Te gustan los números pares o impares? (Escribe 'pares' o 'impares')");

        string preferencia = Console.ReadLine().ToLower();


        int contador = 0;

        foreach (int num in arreglo)

        {

            if (preferencia == "pares" && num % 2 == 0)

            {

                contador++;

            }

            else if (preferencia == "impares" && num % 2 != 0)

            {

                contador++;

            }

        }


        Console.WriteLine($"\nHay {contador} números {preferencia} en el arreglo.");

    }

}