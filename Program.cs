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

// Решение задачи №2 через встроенную функцию:
// int secondToThird(int num)
// {
//     if(num >= 100 && num <= 999)
//     {
//         int ed = num % 10;
//         int dec = (num / 10) % 10;
//         return (int)Math.Pow(dec, ed);
//     }
//     else
//     {
//         Console.WriteLine("Введено не трёхзначное число");
//     }
//     return 0;
// }

// Console.WriteLine("Input number: ");
// int number = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine(secondToThird(number));

// Решение задачи №2 через цикл:
// int secondToThird(int num)
// {
//     if(num >= 100 && num <= 999)
//     {
//         int ed = num % 10;
//         int dec = (num / 10) % 10;
//         int result = dec;
//         for (int i = 0; i < ed-1; i++)
//         {
//             result = result * dec;
//         }
//         return result;
//     }
//     else
//     {
//         Console.WriteLine("Введено не трёхзначное число");
//     }
//     return 0;
// }

// Console.WriteLine("Input number: ");
// int number = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine(secondToThird(number));

Console.WriteLine("Задача 3");
// Напишите программу, которая будет принимать на вход два
// числа и выводить, является ли второе число кратным первому.
// Если второе число некратно первому, то программа выводит
// остаток от деления.
// Примеры
// 14, 5 => нет, 4
// 16, 8 => да
// 4, 3 => нет, 1

// void Task3(int num_1, int num_2)
// {
//     if (num_1 % num_2 == 0)
//     {
//         Console.WriteLine("да");
//     }
//     else
//     {
//         Console.WriteLine("нет, " + num_1 % num_2);
//     }
// }

// Console.WriteLine("Input first number: ");
// int number_1 = Convert.ToInt32(Console.ReadLine());

// Console.WriteLine("Input second number: ");
// int number_2 = Convert.ToInt32(Console.ReadLine());

// Task3(number_1, number_2);

Console.WriteLine("Пример метода Random");
void Task4()
{
    int num = new Random().Next(10, 99 + 1);
    Console.WriteLine(num);
}
Task4();