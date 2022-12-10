/**
 * Программа, формирующая из имеющегося массива строк массив строк, длина которых <= 3.
 */

/**
* Функция, подсчитывающая в заданном массиве строк
* строки длина которых <= 3
 */
int getCountShortEl(string[] srcArray)
{
	int count = 0;
	for (int i = 0; i < srcArray.Length; i++)
	{
		if (srcArray[i].Length < 4) 
			count++;
	}
	return count;
}


/**
* Функция, формирующая из заданного массива строк
* массив строк длина которых <= 3
*/
string[] CreatorArray(string[] srcArray)
{
	string[] dstArray = new string[getCountShortEl(srcArray)];
	for (int i = 0, j = 0; i < srcArray.Length; i++)
	{
		if (srcArray[i].Length < 4)
		{
			dstArray[j] = srcArray[i];
			j++;
		}
	}
	return dstArray;
}

/**
* Функция вывода на печать массива строк
*/
void printArray(string[] array)
{
	Console.Write("[");
	for (int i = 0; i < array.Length; i++)
	{
		Console.Write($"\"{array[i]}\"");
		if ( i != array.Length -1)
			Console.Write(" ");
	}
	Console.WriteLine("]");
}

string[] sourceArray1 = {"hello", "2", "world", ":-)"};
string[] sourceArray2 = {"1234", "1567", "-2", "computer science"};
string[] sourceArray3 = {"Rassia", "Denmark", "Kazan"};

Console.WriteLine("");
Console.Write("Исходный массив: ");
printArray(sourceArray1);
Console.Write("Полученный массив: ");
printArray(CreatorArray(sourceArray1));
Console.WriteLine("");
Console.Write("Исходный массив: ");
printArray(sourceArray2);
Console.Write("Полученный массив: ");
printArray(CreatorArray(sourceArray2));
Console.WriteLine("");
Console.Write("Исходный массив: ");
printArray(sourceArray3);
Console.Write("Полученный массив: ");
printArray(CreatorArray(sourceArray3));
