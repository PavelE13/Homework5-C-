/*Задача 38: Задайте массив вещественных чисел. Найдите разницу между 
максимальным и минимальным элементов массива.
[3 7 22 2 78] -> 76*/

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
    static double[] InitArray (int dimension)
    {
	double[] array = new double[dimension];
	Random rnd = new Random();
	
	for (int i=0;i<dimension;i++)
	{
		array[i]=Math.Round(rnd.NextDouble()*10,3);
	}
	return array;
    }

    //Распечатать массив на консоль
    static void PrintArray (double[] array)
    {
	for (int i=0;i<array.Length;i++) Console.Write(array[i] + "  ");
    }
    
    //Определить разность макс и мин элемента массива
    static double GetCount (double[] array)
    {
        double diff=0;
        int max=0, min=0;
        double maxelem=array[max], minelem=array[min];
            
	    for (int i=0;i<array.Length;i++) 
        {
            if(array[i]>array[max]) 
            {
                maxelem=array[i];
                max=i;
            }
            if(array[i]<array[min]) 
            {
                minelem=array[i];
                min=i;
            }
        }
        Console.WriteLine($"Максимальный элемент массива = {maxelem}");
        Console.WriteLine($"Минимальный элемент массива = {minelem}");
        diff=maxelem-minelem;
	    return diff;
    }

    int dimension=GetNumber("Введите размерность массива: ");
    double [] array=InitArray(dimension);
    PrintArray(array);
    Console.WriteLine("\n");
    Console.WriteLine($"Разница между максимальным и минимальным элементом массива = {GetCount(array)}");