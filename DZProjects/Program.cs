﻿
//const long KKT = 0000143873023403;
//const long ФН = 87100000265158;
//const int ФПД = 6026;
//const long ФПД = 3322278314b;
const long INN = 123456789123;
const string company = "Семерочка";

//var nds = PriceCalc(124.2, 21.5);
//Console.WriteLine(nds);
//double PriceCalc(double price, double nds) => price + price * (nds / 100);

//Console.Write("Введите продукт:");
//string name1 = Console.ReadLine();
//Console.Write("Введите количество:");
//int count1 = int.Parse(Console.ReadLine());
//Console.Write("Введите цену:");
//decimal price1 = int.Parse(Console.ReadLine());


Console.Write("Введите продукт:");
string name2 = Console.ReadLine();
Console.Write("Введите количество:");
int count2 = int.Parse(Console.ReadLine());
Console.Write("Введите цену:");
decimal price2 = int.Parse(Console.ReadLine());

Console.Write("Введите продукт:");
string name3 = Console.ReadLine();
Console.Write("Введите количество:");
int count3 = int.Parse(Console.ReadLine());
Console.Write("Введите цену:");
decimal price3 = int.Parse(Console.ReadLine());
decimal sum = count2 * price2 + count3 * price3;
Console.Title = "Чек ";
Console.WriteLine(
    $"--------------------------------\n" +
    $"Организация: {company}\n" +
    $"ИНН:{INN}\n" +
    $"*********************************\n" +
    $"{"N",-4}{"Название",-10}{"Цена",-6}{"Кол.",-6}{"Сумма",-6} р.\n" +
    // $"{1,-4}{name1,-10}{price1,-6}{count1,-6}{price1 * count1,-6} р.\n" +
    $"{2,-4}{name2,-10}{price2,-6}{count2,-6}{price2 * count2,-6} р.\n" +
    $"{3,-4}{name3,-10}{price3,-6}{count3,-6}{price3 * count3,-6} р.\n" +
    $"{"Итог:",-26}{sum.ToString("c")}");