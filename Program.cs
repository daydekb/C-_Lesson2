/*
Console.WriteLine("Пример выполнения метода типа void");
void NumToQuad(int num)
{
    Console.WriteLine(num*num);
}

Console.WriteLine("Input number: ");
int number = Convert.ToInt32(Console.ReadLine());

NumToQuad(number);
*/

/*
Console.WriteLine("Пример выполнения метода типа int");
int NumToQuad(int num)
{
    return num*num;
}

Console.WriteLine("Input number: ");
int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(NumToQuad(number));
*/

Console.WriteLine("Задача 1");
// Напишите программу, которая принимает на вход
// трёхзначное число и удаляет вторую цифру этого
// числа.
// Примеры
// a = 256 => 26
// a = 891 => 81

// void deleteSecondDigit(int num)
// {
//     if(num >= 100 && num <= 999)
//     {
//         Console.WriteLine($"{num} -> {num/100 * 10 + num % 10}");
//     }
//     else
//     {
//         Console.WriteLine("Введено не трёхзначное число");
//     }
// }

// Console.WriteLine("Input number: ");
// int number = Convert.ToInt32(Console.ReadLine());

// deleteSecondDigit(number);

Console.WriteLine("Задача 2");

// Напишите программу, которая принимает на вход трёхзначное
// число и возводит вторую цифру этого числа в степень, равную
// третьей цифре.
// Примеры
// 487 => 8^7 = 2 097 152
// 254 => 5^4 = 625
// 617 => 1

void deleteSecondDigit(int num)
{
    if(num >= 100 && num <= 999)
    {
        Console.WriteLine($"{num} -> {num/100 * 10 + num % 10}");
    }
    else
    {
        Console.WriteLine("Введено не трёхзначное число");
    }
}

Console.WriteLine("Input number: ");
int number = Convert.ToInt32(Console.ReadLine());

deleteSecondDigit(number);