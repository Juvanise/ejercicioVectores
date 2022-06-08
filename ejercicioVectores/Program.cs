
Console.WriteLine("Ingrese el tamaño del vector");
int tamanio = int.Parse(Console.ReadLine());

int[] vector = new int[tamanio];

Random aleatorio = new Random();

for (int i = 0; i < vector.Length; i++)
{
    vector[i] = aleatorio.Next(100);
}

foreach (var item in vector)
{
    Console.Write(item + " ");
}

Console.WriteLine();
Console.WriteLine("El vector invertido es:");

for (int i = vector.Length - 1; i >= 0; i--)
{
    Console.Write(vector[i]+ " ");
}