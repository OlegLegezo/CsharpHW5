// Задача 36: Задайте одномерный массив, заполненный
// случайными числами. Найдите сумму элементов, стоящих
// на нечётных позициях.
// [3, 7, 23, 12] -> 19
// [-4, -6, 89, 6] -> 0


Console.WriteLine("введите размер массива");//у меня уже было готовое решение на ввод пользователем размера массива
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


int oddPosSum = 0;
for (int i = 0; i < arr.Length; i = i + 2)
{
    oddPosSum = arr[i] + oddPosSum;
}
Console.WriteLine($"сумма нечётных элементов (счёт элементов массива идет с 1) = {oddPosSum}");