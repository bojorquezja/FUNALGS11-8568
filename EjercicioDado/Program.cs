﻿int u = 0;

Console.WriteLine("Cuantos elementos desea tener en su conjunto: ");
u = int.Parse(Console.ReadLine());
int[] numeros = new int[u];
int contP=0, contI=0;
char resp;
foreach (int i in numeros) { 
    Random rnd = new Random();
    numeros[i] = rnd.Next(50, 90 + 1);
    if ((numeros[i] % 2) == 0)
    {
        contP++;
    }
    else { 
        contI++;
    }
}
do
{
    Console.WriteLine("Le gusta los numeros pares o impares? (P/I)");
    resp = char.Parse(Console.ReadLine().ToUpper());
} while (resp != 'P' && resp != 'N');
string tabla = string.Join(", ", numeros);
Console.WriteLine(tabla);
if (resp == 'P') { 
    Console.WriteLine(contP);
}
if (resp == 'N') { 
    Console.WriteLine(contI);
}
