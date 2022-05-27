// Задача 38: Задайте массив вещественных чисел. Найдите
// разницу между максимальным и минимальным
// элементов массива.
// [3 7 22 2 78] -> 76


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


int maxElement = arr[0];
int minElement = arr[0];

for (int i = 0; i < arr.Length; i++)
{
    if (arr[i] > maxElement)
    {
        maxElement = arr[i];
    }
    else if (arr[i] < minElement)
    {
        minElement = arr[i];
    }
}
Console.WriteLine($"Максимальный элемент массива = {maxElement}");
Console.WriteLine($"Минимальный элемент массива = {minElement}");

int answer = maxElement - minElement;
Console.WriteLine($"Дельта равна {answer}");