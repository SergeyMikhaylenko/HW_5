// Задача 34: Задайте массив заполненный случайными положительными трёхзначными числами.
//  Напишите программу, которая покажет количество чётных чисел в массиве.

int [] array = {121, 222, 333, 444, 555, 666, 777, 888, 999};

int size = array.Length;
int evenArrayElements=0;
for (int index = 0; index < size; index++)
{
 if ((array[index] %2) ==0)
 {
    evenArrayElements++;
 }
}
Console.WriteLine("Количество четных чисел в массиве " + evenArrayElements); 


// Через рандом 

// int[] array = new int [10];
// int size = array.Length;
// int evenArrayElements=0;
// for (int index = 0; index < size; index++)
// {
// array[index] =new Random().Next(1,10);

// if ((array[index] %2) ==0)
//  {
//     evenArrayElements++;
//  }
// }
// Console.WriteLine("Количество четных чисел в массиве " + evenArrayElements);
// Console.WriteLine($"{String.Join("; ", array )}");
