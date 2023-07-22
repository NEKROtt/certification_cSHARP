/*  
Задайте значение N. Напишите программу, которая выведет все натуральные числа в промежутке от N до 1. Выполнить с помощью рекурсии. 
N = 5 -> "5, 4, 3, 2, 1" 
N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1" 
*/ 
 
using System; 
using static System.Console; 
Clear(); 
 
Write("Введите конечное число: "); 
int begin = int.Parse(ReadLine()); 
Write("Введите N: "); 
int n = int.Parse(ReadLine()); 
 
WriteLine(PrintNumbers(begin, n)); 
 
string PrintNumbers(int first, int last) 
{; 
    if (last == first) return last.ToString(); 
    return (last + " " + PrintNumbers(first, last - 1)); 
}


