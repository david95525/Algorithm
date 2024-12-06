// See https://aka.ms/new-console-template for more information

using static Algorithm.Basic;
Console.WriteLine("請輸入要選擇的演算法");
Console.WriteLine("1.Fibonacci,2.");
int? choose = int.Parse(Console.ReadLine());
if (choose == 1)
{
    Fibonacci_Algorithm();
}
Console.ReadKey();
