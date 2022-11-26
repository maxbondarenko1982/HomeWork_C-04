// Задача 29: Напишите программу, которая задаёт массив из N элементов 
// и выводит их на экран. Вывод сделать отдельным методом.
// 5 -> [1, 2, 5, 7, 19]
// 3 -> [6, 1, 33]

int[] array = new int[5];

void PrintArray(int[] array)
{
    for (int i = 0; i<array.Length; i++)
    {
    array[i] = new Random().Next(1,5);
    Console.Write(array[i] + " ");
    }
}
PrintArray(array);



