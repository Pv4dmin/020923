//Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, 
//которая покажет количество чётных чисел в массиве.
//[345, 897, 568, 234] -> 2

int InputNum(string massage)
{
	Console.Write($"{massage}: ");
	return int.Parse(Console.ReadLine()!);
}


void FillArray(int[] newArray)
{
	Console.Write("[ ");
	for (int i = 0; i < newArray.Length; i++)
	{
		newArray[i] = new Random().Next(100, 1000);
		Console.Write($"{newArray[i]} ");
	}
	Console.WriteLine("]");
}

int TreeDigit(int[] array)
{
	int count = 0;
	for (int i = 0; i < array.Length; i++)
	{
		
		if (array[i] % 2 == 0)
		{
			count += 1;
		}
	}
	return count;
}

int size = InputNum("Введите размер массива");
int[] newArray = new int[size];
FillArray(newArray);
int sum = TreeDigit(newArray);
Console.WriteLine($"Сумма четных чисел в массиве: {sum}");
