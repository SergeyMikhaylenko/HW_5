// Задача 36: Задайте одномерный массив, заполненный случайными числами. 
// Найдите сумму элементов, стоящих на нечётных позициях.

int [] array = {1, 2, 3, 4, 5, 6, 7, 8, 9};
int size = array.Length;
int sum=0;
for (int index = 1; index < size; index+=2)
{   
 sum+=array[index];
}
Console.WriteLine("сумма элементов, стоящих на нечётных позициях.: " + sum);



// Через рандом.

// int[] array = new int [10];   
// int size = array.Length;
// int sum=0;
// for (int index = 1; index < size; index+=2)
// {   
//  array[index] = new Random().Next(1, 10);
//  sum+=array[index];
// }
// Console.WriteLine("сумма элементов, стоящих на нечётных позициях.: " + sum);
// Console.WriteLine($"{String.Join("; ", array )}");