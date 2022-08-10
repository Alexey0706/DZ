//Задача 6: Напишите программу, которая на вход принимает число и выдаёт, является ли число чётным (делится ли оно на два без остатка).
Console.Write(value: "Введите число: ");
int number = Convert.ToInt32(value: Console.ReadLine());

if(number % 2 == 0){
    Console.WriteLine($"{number} is EVEN");
}
else
{
    Console.WriteLine($"{number} is ODD");
}
