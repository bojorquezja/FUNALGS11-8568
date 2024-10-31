void imprime(int[] lis) {
    foreach (int x in lis) {
        Console.WriteLine(x);
    }
}

int[] lista = {5,6,8,9};

imprime(lista);

/*
 * a-pedir numero y posicion
 * b-aumentar tamaño de arreglo
 * c-desplazar numeros hacia el final hasta insertar nuevo valor
*/

Console.WriteLine("Ingrese numero a insertar");
int n = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Ingrese posicion donde insertar");
int p = Convert.ToInt32(Console.ReadLine()) - 1;

Array.Resize(ref lista, lista.Length + 1);
for (int x = lista.Length-1; x > p; x--) {  //x = x-1
    lista[x] = lista[x - 1];
}
lista[p] = n;

imprime(lista);