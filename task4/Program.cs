//  Задача 4: Напишите программу, которая принимает на вход 
//  три числа и выдаёт максимальное из этих чисел.

//  2, 3, 7 -> 7
//  44 5 78 -> 78
//  22 3 9 -> 22

// В задаче не указано, какие должны быть числа, мы должны это уточнить, 
// но так как в примерах указаны только целые числа, работаем с ними, но в обращении к
// пользователю укажем "Введите 3 целых числа" 

Console.WriteLine("Введите 3 целых числа");

int num1 = int.Parse(Console.ReadLine());
int num2 = int.Parse(Console.ReadLine());
int num3 = int.Parse(Console.ReadLine());

int result = num1;
if(result < num2) result = num2;
if(result < num3) result = num3;

Console.WriteLine("max = " + result);

