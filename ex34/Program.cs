// Задача 34: Задайте массив заполненный случайными
// положительными трёхзначными числами. Напишите
// программу, которая покажет количество чётных чисел в
// массиве.
// [345, 897, 568, 234] -> 2


Console.WriteLine("введите размер массива");
int num = int.Parse(Console.ReadLine());//сразу перевели число в инт

Random rnd = new Random();

//метод создания массива
int[] initArray(int size)
{
    int[] array = new int[size];
    for (int i = 0; i < array.Length; i++)
    {
        array[i] = rnd.Next(100, 1000);
        //Console.Write(array[i] + " "); //если нужно отобразить
    }
    return array;
}
//метод создания массива

int[] arr = initArray(num);
string st = string.Join(", ", arr);//компаную массив в красивую строку
Console.WriteLine(st);

int evenNumber = 0;
for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] % 2 == 0)
    evenNumber=evenNumber+1;
}
Console.WriteLine($"сумма чётных элементов = {evenNumber}");