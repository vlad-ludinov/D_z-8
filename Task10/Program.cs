using static System.Console;

Write("Введите трёхзначное число: ");
int number = int.Parse(ReadLine()!);

WriteLine(99<number && number<1000?number%100/10:"число не трёхзначное");

