//Задача 36: Задайте одномерный массив, заполненный случайными числами. 
//Найдите сумму элементов, стоящих на нечётных позициях.
//[3, 7, 23, 12] -> 19


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
		newArray[i] = new Random().Next(10, 100);
		Console.Write($"{newArray[i]} ");
	}
	Console.WriteLine("]");
}

int NewArray(int[] array)
{
	int sum = 0;
	int i = 1;
	while (i < array.Length)
	{
		sum = sum + array[i];
		i = i + 2;
	}
	return sum;
}

int size = InputNum("Введите размер массива");
int[] newArray = new int[size];
FillArray(newArray);
int sum = NewArray(newArray);
Console.WriteLine($"Сумма чисел стоящих на нечетных позициях: {sum}");