/*
Задача 38: Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76

*/

// метод, который считывает с консоли (для размерности массива + границы случ. чисел)
int GetNumber(string message)
{
int result = 0;

while(true)
{
Console.WriteLine(message);

if(int.TryParse(Console.ReadLine(), out result))
{
break;
}
else
{
Console.WriteLine("Ввели не число");
}
}

return result;
}

//метод для инициализации массива рандомными числами
int[] InitArray(int dimension, int rightBound, int leftBound)
{
int[] result = new int[dimension];
Random rnd = new Random();

for (int i = 0; i < dimension; i++)
{
result[i] = rnd.Next(leftBound, rightBound);
}
return result;
}

//метод для печати массива
void PrintArray(int [] array)
{
for (int i = 0; i < array.Length; i++)
{
Console.Write($"{array[i]} ");
}
Console.WriteLine();
}

int dimensin = GetNumber("Введите размерность массива");
int leftBound = GetNumber("Введите левую границу значений");
int rightBound = GetNumber("Введите правую границу значений");
int[] arr = InitArray(dimensin, rightBound, leftBound);

// нахождение  минимального и максимального значений массива
Array.Sort(arr);
int MinNumber = arr[0];
int MaxNumber = arr[arr.Length - 1];

int Diff = MaxNumber - MinNumber;

PrintArray(arr);

Console.WriteLine("Минимальное значение массива - " + arr[0]);
Console.WriteLine("Максимальное значение массива - " + arr[arr.Length - 1]);
Console.WriteLine($"Разницу между максимальным и минимальным значениями массива - {Diff}");
