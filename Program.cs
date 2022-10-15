// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

int[] array1 = GetArray(10, 100, 1000);

Console.WriteLine("-------Первая задача-------");
Console.WriteLine(String.Join(", ", array1));
Console.WriteLine($"{FindElement(array1)} четных чисел");

int FindElement(int[] array1){
    int count = 0;
    foreach(var x in array1){
        if (x % 2 == 0) count++;}
    return count;
}


// Задача 36: Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.

// [3, 7, 23, 12] -> 19

// [-4, -6, 89, 6] -> 0

int[] array2 = GetArray(5, -50, 50);

Console.WriteLine("-------Вторая задача-------");
Console.WriteLine(String.Join(", ", array2));
Console.WriteLine(GetSum(array2));

int GetSum(int[] array2){
    int sum = 0;
    for(int i = 0; i < array2.Length; i = i+2){
        sum += array2[i];
    }
    return sum;
}    




int[] GetArray(int size, int minValue, int maxValue){
    int[] res = new int[size];

    for (int i = 0; i < size; i++){
        res[i] = new Random().Next(minValue, maxValue+1);
    }
    return res;
}