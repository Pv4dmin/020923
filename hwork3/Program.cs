//Задача 38: Задайте массив вещественных чисел. 
//Найдите разницу между максимальным и минимальным элементов массива.
//[3.22, 4.2, 1.15, 77.15, 65.2] => 77.15 - 1.15 = 76

int InputNum(string massage)
{
	Console.Write($"{massage}: ");
	return int.Parse(Console.ReadLine()!);
}

void NewArray(double[] doubles)
{
	Random rnd = new Random();
	Console.Write("[ ");
	for (int i = 0; i < doubles.Length; i++)
	{
		int max = -20;
		int min = 50;
		doubles[i] = Math.Round(rnd.NextDouble() * (max - min) + min, 2);
	}
	Console.WriteLine(String.Join(" ", doubles) + " ]");
}

void Diff(double[] dif)
{
	double max = 0;
	double min = 0;
	for (int i = 0; i < dif.Length; i++)
	{
		if (dif[i] > max)
			max = dif[i];
		if (dif[i] < min)
			min = dif[i] + min;
	}
	Console.WriteLine($"Максимальное число в массиве {max}");
	Console.WriteLine($"Минимальное число в массиве {min}");
	double res = max - min;
	double resoult = Math.Max(res, 2);
	Console.WriteLine($"Разница между ними равна {resoult}");
}

int size = InputNum("Введите размер массива");
double[] newArray = new double[size];
NewArray(newArray);
Diff(newArray);
