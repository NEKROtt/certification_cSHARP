/* 
Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных элементов в промежутке от M до N. 
M = 1; N = 15 -> 120 
M = 4; N = 8. -> 30 
*/ 
 
using System; 
using static System.Console; 
Clear(); 
 
Write("Введите начальное число: "); 
int first = int.Parse(ReadLine()); 
Write("Введите конечное число: "); 
int second = int.Parse(ReadLine()); 
 
WriteLine($"Cумма чисел {first} и {second} = {SumNumbers(first, second)}"); 
 
int SumNumbers(int begin, int last) 
{ 
    if (begin == last) return begin; 
    return (begin + SumNumbers(begin + 1, last)); 
}