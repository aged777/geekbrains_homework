//  Задача 2: 
//  Напишите программу, которая на вход принимает два числа и выдаёт, 
//  какое число большее, а какое меньшее.

//  a = 5; b = 7 -> max = 7
//  a = 2 b = 10 -> max = 10
//  a = -9 b = -3 -> max = -3

// В задаче не указано, какие должны быть числа, мы должны это уточнить, 
// но так как в примерах указаны только целые числа, работаем с ними, но в обращении к
// пользователю укажем "Введите 2 целых числа" 

Console.WriteLine("Введите 2 целых числа: ");

int num1 = int.Parse(Console.ReadLine());
int num2 = int.Parse(Console.ReadLine());

if(num1 < num2) Console.WriteLine("max = " + num2);
else if(num1 > num2) Console.WriteLine("max = " + num1);
else Console.WriteLine("Числа равны.");
