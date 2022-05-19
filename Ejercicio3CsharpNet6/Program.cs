int[] numeros = new int[10];
for (int i = 0; i < numeros.Length; i++)
{
    Console.Write($"Por favor, ingrese el {i + 1}º numero: ");
    numeros[i] = int.Parse(Console.ReadLine());
}

Console.WriteLine($"La suma de los numeros ingresados es: {numeros.Sum()}");
Console.WriteLine($"El mayor de los numeros ingresados es: {numeros.Max()}");
Console.WriteLine($"El menor de los numeros ingresados es: {numeros.Min()}");
Console.WriteLine($"El promedio de todos los numeros ingresados es: {numeros.Average()}");
Console.Write($"Los numeros ingresados fueron: ");
for (int i = 0; i < numeros.Length; i++)
{
    Console.Write($"{numeros[i]} ");
}
