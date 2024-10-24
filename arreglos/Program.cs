Console.WriteLine("Ingresar cantidad de elementos:");
int n = int.Parse(Console.ReadLine());
int[] numeros = new int[n];
Random ran = new Random();  

for (int i = 0; i < n; i++){
    numeros[i] = ran.Next(50, 98 + 1);
}
string todos = string.Join(",", numeros);
Console.WriteLine($"numeros: {todos}");

Console.Write("Cual prefieres I o P: ");
string pref = Console.ReadLine();

for (int i = 0; i < n; i++){
    if (numeros[i] % 2 == 0 && pref == "P") {
        Console.WriteLine(numeros[i]);
    }else{
        if (numeros[i] % 3 == 0 && pref == "I"){
            Console.WriteLine(numeros[i]);
        }
    }
}
/* xddd 