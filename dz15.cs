﻿//Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
int [] array = GetArray (12 ,100 , 999 );
int sum =0;
Console.WriteLine(String.Join(" ", array));
int [] GetArray (int size, int minValue, int maxValue)
{
    int[] res = new int [size];
    for (int i =0; i< size;i++ )
    {
        res[i] = new Random().Next(minValue, maxValue+1);
    }
    return res;
}
for (int i = 0; i< array.Length;i++){
    if(array[i]%2==0){
        sum +=1;
    }
}
Console.WriteLine("Количестов четных элементов: " + sum);

