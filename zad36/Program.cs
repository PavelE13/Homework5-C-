/*Задача 36: Задайте одномерный массив, заполненный случайными числами. 
Найдите сумму элементов, стоящих на нечётных позициях.
[3, 7, 23, 12] -> 19
[-4, -6, 89, 6] -> 0 2*/

// Метод проверки данных на размерность массива
    static int GetNumber(string message)
    {
    int result;
    while (true)
    {
        Console.WriteLine(message);
        if (int.TryParse(Console.ReadLine(), out result) && result > 0)
            break;
        else
            Console.WriteLine("Вы ввели неверное число. Введите корректное число");
    }
    return result;
    }
    
    //Получить заполненный масств рандомными числами
    static int[] InitArray (int dimension)
    {
	int[] array = new int[dimension];
	Random rnd = new Random();
	
	for (int i=0;i<dimension-1;i++)
	{
		array[i]=rnd.Next(-3,9);
	}
	return array;
    }

    //Распечатать массив на консоль
    static void PrintArray (int[] array)
    {
	for (int i=0;i<array.Length;i++) Console.Write(array[i] + "  ");
    }
    
    //Определить элемент массива
    static int GetCount (int[] array)
    {
        int sum=0;
	    for (int a=1;a<array.Length;a+=2) sum+=array[a];
	return sum;
    }

    int dimension=GetNumber("Введите размерность массива: ");
    int[] array=InitArray(dimension);
    PrintArray(array);
    Console.WriteLine("\n");
    Console.WriteLine($"Сумма элементов, стоящих на нечётных позициях = {GetCount(array)}");