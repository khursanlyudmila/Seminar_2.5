/*
Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0
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

// метод нахождения суммы элементов, стоящих на нечетных позициях в массиве
int FindPositiveSum(int[] array)
{
int sum = 0;
for (int i = 1; i < array.Length; i+=2)
{
if(array[i] > 0)
sum += array[i];
}
return sum;
}

int dimensin = GetNumber("Введите размерность массива");
int leftBound = GetNumber("Введите левую границу значений");
int rightBound = GetNumber("Введите правую границу значений");
int[] arr = InitArray(dimensin, rightBound, leftBound);

PrintArray(arr);

Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях в массиве - {FindPositiveSum(arr)}");