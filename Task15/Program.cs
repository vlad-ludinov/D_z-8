using static System.Console;

Write("Введите число: ");
int number = int.Parse(ReadLine()!);

WriteLine(0<number && number<8?number/6==1?"Да":"Нет":"Такого дня нет");