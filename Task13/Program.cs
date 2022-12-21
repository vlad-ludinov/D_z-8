using static System.Console;

Write("Введите число: ");
int number = int.Parse(ReadLine()!);

WriteLine(number > 99?number%1000/100:"третьей цифры нет");