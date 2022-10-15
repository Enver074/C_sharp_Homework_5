// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.

// [345, 897, 568, 234] -> 2

int[] array1 = GetArray(10, 100, 1000);

Console.WriteLine(String.Join(", ", array1));
Console.WriteLine($"{FindElement(array1)} четных чисел");

int FindElement(int[] array1){
    int count = 0;
    foreach(var x in array1){
        if (x % 2 == 0) count++;}
    return count;
}


int[] GetArray(int size, int minValue, int maxValue){
    int[] res = new int[size];

    for (int i = 0; i < size; i++){
        res[i] = new Random().Next(minValue, maxValue+1);
    }
    return res;
}