//Задача 2: Напишите программу, которая на вход принимает два числа и выдаёт, какое число большее, а какое меньшее.
Console.Write(value: "Введите первое число: ");
int namber1 = Convert.ToInt32(value: Console.ReadLine());

Console.Write(value: "Введите второе число: ");
int namber2 = Convert.ToInt32(value: Console.ReadLine());

int max = namber1;

if(namber1 > max) max = namber1;
if(namber2 > max) max = namber2;

Console.WriteLine(value: $"MAX = {max}");
