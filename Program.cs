// Задача 64: Задайте значение N. Напишите программу, которая выведет все натуральные числа 
// в промежутке от N до 1. Выполнить с помощью рекурсии.
// N = 5 -> "5, 4, 3, 2, 1"
// N = 8 -> "8, 7, 6, 5, 4, 3, 2, 1"

// Console.Write("Введите натуральное число больше 1: ");
// int number = Convert.ToInt32(Console.ReadLine());
 
// void NaturalNumber(int number)
// {
//     if (number < 0) Console.Write($"{number} не натульное");
    
//     if (number == 0) return;
//     Console.Write($" {number}");
//     NaturalNumber(number - 1);
// }
 
// NaturalNumber(number);


// Задача 66: Задайте значения M и N. Напишите программу, которая найдёт сумму натуральных 
// элементов в промежутке от M до N.
// M = 1; N = 15 -> 120
// M = 4; N = 8. -> 30

// Console.Write("Введите левую границу промежутка M: ");
// int M = Convert.ToInt32(Console.ReadLine());
// Console.Write("Введите правую границу промежутка N: ");
// int N = Convert.ToInt32(Console.ReadLine());
 
// Console.Write($"Сумма элементов от {M} до {N} : равна {Sum(M,N)}");
// //  Сумма элементов
// int Sum(int M, int N){
//     if (M ==N) return N;
//     else 
//      return M + Sum(M + 1, N);
// }



// Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. 
// Даны два неотрицательных числа m и n.
// m = 2, n = 3 -> A(m,n) = 9
// m = 3, n = 2 -> A(m,n) = 29

Console.Write("Введите первое неотрцательное число m: ");
int m = Convert.ToInt32(Console.ReadLine());
Console.Write("Введите второе неотрицательное число n: ");
int n = Convert.ToInt32(Console.ReadLine());
 
Console.Write($"Функция Аккермана равна {Akk(m, n)} ");
 
// Аккерман
int Akk(int m, int n)
{
if (m == 0) return n + 1;
else if (m > 0 && n == 0) return Akk(m -1, 1);
else return Akk(m-1, Akk(m, n -1));
}