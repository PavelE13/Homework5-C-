   /*Задача 34: Задайте массив заполненный случайными положительными 
   трёхзначными числами. Напишите программу, которая покажет количество 
   чётных чисел в массиве.
   [345, 897, 568, 234] -> 2*/

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
	
	for (int i=0;i<dimension;i++)
	{
		array[i]=rnd.Next(100,1000);
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
        int count=0;
	    for (int i=0;i<array.Length;i++)
	    {
		    if(array[i]%2==0) count++;
	    }
	return count;
    }

    int dimension=GetNumber("Введите размерность массива: ");
    int[] array=InitArray(dimension);
    PrintArray(array);
    Console.WriteLine($"Количество четных чисел в массиве = {GetCount(array)}");