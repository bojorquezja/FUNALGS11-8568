using System.Collections.Generic;

void imprime(int[] lis) {
    foreach (int x in lis) {
        Console.WriteLine(x);
    }
}

int[] lista = new int[5];

Random rand = new Random();
for (int x = 0; x < lista.Length; x++) {
    lista[x] = rand.Next(1, 10 + 1);
}
imprime(lista);

Console.WriteLine();
Console.WriteLine("Ingrese nuevo numero");
int n = Convert.ToInt32(Console.ReadLine());

Array.Resize(ref lista, lista.Length + 1);
lista[lista.Length - 1] = n;
imprime(lista);