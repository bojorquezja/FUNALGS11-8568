/* Pida al usuario que defina la cantidad de elementos de un arreglo
 * de enteros, llenelos con valores aleatorios entre 50 y 90 y luego pregunte al usuario
 * si le gustan los numeros pares o impares. Debe responder la cantidad de pares e impares
*/


Console.WriteLine("Cantidad de datos: ");
int n=int.Parse(Console.ReadLine());

int[] num1 = new int[n];
Random rnd = new Random();

int c = 0;
for (int i = 0; i<n; i++)
{
    num1[i]= rnd.Next(50,91);


}
string todo = string.Join(" ", num1);
Console.WriteLine("Numeros: " + todo);

Console.WriteLine("Te gustan pares o impares?: ");
string put = Console.ReadLine().ToLower();
if (put == "pares")
{
    Console.WriteLine("Pares: " + (num1 % 2 == 0);
    c++;

}
else if (put == "impares")
{

    c++;
}
