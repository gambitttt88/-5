//Задайте массив заполненный случайными положительными трёхзначными числами. 
//Напишите программу, которая покажет количество чётных чисел в массиве.
/*int[] array= GetArray(6, 100, 999);
Console.WriteLine($"[{String.Join(",", array)}]");

int CountElement(int[] array)
{   
    int count = 0;
    foreach(int el in array)
    {
        if(el % 2==0)
        {
            count++;
        }
    } 
    return count;
}
Console.WriteLine($"Количество четных элементов в отрезке {CountElement(array)}");

int[] GetArray(int size, int minValue, int maxValue){
    int[] res = new int[size];
    for(int i = 0; i < size; i++){
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}*/

//Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных индексах.
/*int[] array= GetArray(10, 1, 99);
Console.WriteLine($"[{String.Join(", ", array)}]");

int CountElement(int[] array)
{   
    int sum = 0;
    for(int i = 0; i < array.Length; i++)
    {
        if(i % 2!=0)
        {
            sum+=array[i];
        }
    } 
    return sum;
}
Console.WriteLine($"Сумма чисел на нечетных индексах равна: {CountElement(array)}");

int[] GetArray(int size, int minValue, int maxValue){
    int[] res = new int[size];
    for(int i = 0; i < size; i++){
        res[i] = new Random().Next(minValue, maxValue + 1);
    }
    return res;
}*/

//Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. 
//Результат запишите в новом массиве.
int[] array= GetArray(21, 1, 10);
Console.WriteLine($"[{String.Join(", ", array)}]");
int[] resultArray = new int [array.Length / 2];
  
for (int i = 0; i <array.Length / 2; i++)
{
    resultArray[i]= array[i] * array[array.Length - 1 - i];
}
            
Console.WriteLine($"[{String.Join(", ", resultArray)}]");

int[] GetArray(int size, int minValue, int maxValue)
{
    int[] res = new int[size];
    for(int i = 0; i < size; i++){
        res[i] = new Random().Next(minValue, maxValue + 1);
    }return res;
}
    