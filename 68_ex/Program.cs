/* 
 Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n. 
m = 2, n = 3 -> A(m,n) = 9 
m = 3, n = 2 -> A(m,n) = 29 
*/ 
 
using System; 
using static System.Console; 
Clear(); 
 
Write("Введите M: "); 
int first = int.Parse(ReadLine()); 
Write("Введите N: "); 
int second = int.Parse(ReadLine()); 
 
WriteLine($"Функция Аккермана {first}, {second} = {FormulaAkk(first, second)}"); 
 
int FormulaAkk(int m, int n) 
{ 
    if (m == 0) return n + 1; 
    if (n == 0) return FormulaAkk(m - 1, 1); 
    return FormulaAkk(m - 1, FormulaAkk(m, n - 1)); 
}
