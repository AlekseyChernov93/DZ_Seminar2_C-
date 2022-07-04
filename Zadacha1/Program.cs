/* Напишите программу, которая принимает
на вход трёхзначное число и
на выходе показывает вторую цифру этого числа.
456 -> 5
782 -> 8
918 -> 1 */

int Znach3()
{
    Console.WriteLine("Введите трехзначное число ");
    int n = Convert.ToInt32(Console.ReadLine());
    int des = n % 100;
    int n2 = des / 10;
    return n2;
}
int result = Znach3();
Console.WriteLine($"Третье число введеного числа:  {result}");