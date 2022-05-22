//Pedir 10 números al usuario.
int[] numeros = new int[10];

string separador = "---------------------------------------------";

for (int i = 0; i < numeros.Length; i++)
{
    Console.WriteLine($"Ingrese el {i+1}° Número: ");
    numeros[i] = int.Parse(Console.ReadLine());
}

int suma = 0;

for (int i = 0; i < numeros.Length; i++)
{
    suma += numeros[i]; //acumulador
}


Console.WriteLine($"La suma de todos los N° Ingresados es: {suma}");

Console.WriteLine(separador);

int promedio = suma / numeros.Length;
Console.WriteLine($"El promedio de todos los N° Ingresados es: {promedio}");

Console.WriteLine(separador);

Console.WriteLine("los valores ingresados son: ");


foreach (var item in numeros)
{
    Console.Write(item + " | ");
}

Console.WriteLine();

int n = numeros.Length;

// Bucle para ordenar los indices de mayor a menor metodo Insercion directa

for (int i = 1; i < n; ++i)
{
    int key = numeros[i];
    int j = i - 1;


    while (j >= 0 && numeros[j] < key)
    {
        numeros[j + 1] = numeros[j];
        j = j - 1;
    }
    numeros[j + 1] = key;
}

Console.WriteLine("El numero mayor es: " + numeros[0]);

Console.WriteLine("---------------------------------------");

Console.WriteLine("El numero menor es: " + numeros[9]);

Console.WriteLine("---------------------------------------");




