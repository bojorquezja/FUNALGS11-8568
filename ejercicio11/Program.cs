using System;



class Program
{
    static void Main()
    {
        // 1. Solicitar la cantidad de elementos del arreglo
        Console.Write("¿Cuántos elementos deseas en el arreglo? ");
        int n = int.Parse(Console.ReadLine());
        // 2. Crear el arreglo y llenarlo con números aleatorios entre 50 y 90
        int[] arreglo = new int[n];
        Random random = new Random();
        Console.WriteLine("\nArreglo generado:");

        for (int i = 0; i < n; i++)
        {
            arreglo[i] = random.Next(50, 91); // Genera números entre 50 y 90 (inclusive)
            Console.Write(arreglo[i] + " ");
        }
        // 3. Preguntar al usuario si le gustan los pares o impares
        Console.WriteLine("\n\n¿Te gustan los números pares o impares? (Escribe 'pares' o 'impares')");
        string preferencia = Console.ReadLine().ToLower();
        // 4. Contar pares o impares según la preferencia del usuario
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
        // 5. Mostrar el resultado

        Console.WriteLine($"\nHay {contador} números {preferencia} en el arreglo.");
    }
}