Main();

void Main()
{
	bool isWorking = true;
	while (isWorking)
	{
		Console.Write("Input command: ");
		switch (Console.ReadLine())
		{
			case "Task64": Task64(); break;
			case "Task66": Task66(); break;
            case "Task68": Task68(); break;
			case "exit": isWorking = false; break;
		}
		Console.WriteLine();
	}
}
// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. 
//Выполнить с помощью рекурсии.
void Task64()
{
    int n = InputInt("Введите число ");
    int m = 1;
    Console.WriteLine(NaturalNumber(n, m));
}
Task64();

int NaturalNumber(int n, int m)
{
    
    if (n == m)
        return n;
    else
        Console.Write($"{NaturalNumber(n, m + 1)}, ");
    return m;
}

int InputInt(string output)
{
    Console.Write(output);
    return int.Parse(Console.ReadLine());
}

//Задача 66: Задайте значения M и N. Напишите программу, 
//которая найдёт сумму натуральных элементов в промежутке от M до N.
void Task66()
{
    int m = InputInt("Введите M:");
    int n = InputInt("Введите N:");
    Console.WriteLine($"Сумма элементов от {m} до {n} = {SumNaturalNambers(m, n)}");
}
Task66();

int SumNaturalNambers(int m, int n)
{
    if (m == n)
        return n;
    return n + SumNaturalNambers(m, n - 1);
}

//Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии.
// Даны два неотрицательных числа m и n.
void Task68()
{
    Console.WriteLine("Введите два положительных числа: M и N.");
    int m = InputInt("Введите M: ");
    int n = InputInt("Введите N: ");
    Console.WriteLine($"A({m}, {n}) = {Akkerman(m, n)}");
}
Task68();

int Akkerman(int m, int n)
{
    if (m == 0)
        return n + 1;
    if (m > 0 && n == 0)
        return Akkerman(m - 1, 1);
    else
        return Akkerman(m - 1, Akkerman(m, n - 1));
}