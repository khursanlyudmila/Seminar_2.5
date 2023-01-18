/*
Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
[345, 897, 568, 234] -> 2
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

int[] InitArray(int dimension, int leftBound, int rightBound)
{
int[] result = new int[dimension];
Random rnd = new Random();

for (int i = 0; i < dimension; i++)
{
result[i] = rnd.Next(leftBound, rightBound);
}
return result;
}

/*
void FillArrayRandomNumbers(int[] array)
{
    for(int i = 0; i < array.Length; i++)
    {
        array[i] = new Random().Next(100,1000);
    }
}
*/

//метод для печати массива
void PrintArray(int [] array)
{
for (int i = 0; i < array.Length; i++)
{
Console.Write($"{array[i]} ");
}
Console.WriteLine();
}

// метод нахождения количества четных чисел в массиве

int FindEverNumber(int[] array)
{
    int count = 0;
    for (int i=0; i < array.Length; i++)
    {
        if (array[i] %2 == 0)
            count++;
    }
    return count;
}

int dimensin = GetNumber("Введите размерность массива");
int leftBound = GetNumber("Введите левую границу значений, число больше 99");
int rightBound = GetNumber("Введите правую границу значений, число меньше 1000");

if (leftBound >=100 && rightBound < 1000)
{
int[] arr = InitArray(dimensin, leftBound, rightBound);
PrintArray(arr);
Console.WriteLine($"Количество четных чисел в массиве - {FindEverNumber(arr)}");
}
else
Console.WriteLine("Границы не соответствуют заданным параметрам");
