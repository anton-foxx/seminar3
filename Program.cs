// Напишите программу, которая принимает на вход пятизначное число и 
// проверяет, является ли оно палиндромом.
// 14212 -> нет
// 12821 -> да
// 23432 -> да


// Console.Clear();
// Console.Write("Введите пятизначное число: ");
// int num = Convert.ToInt32(Console.ReadLine());
// int a = num % 10;
// int b = num / 1000 % 10;
// int c = num % 100 / 10;
// int d = num / 10000;

// if (num > 100000 || num < 10000)
// {
//     Console.WriteLine("Перезапустите программу и введите пятизначное число: ");
// }
// else if (a == d && b == c)
// {
//     Console.WriteLine("Число палиндром");
// }
// else
// {
//     Console.WriteLine("Число НЕ палиндром");
// }


// Напишите программу, которая принимает на вход координаты двух точек и 
// находит расстояние между ними в 3D пространстве.
// A (3,6,8); B (2,1,-7), -> 15.84
// A (7,-5, 0); B (1,-1,9) -> 11.53

// Console.WriteLine("Введите координаты X, Y, Z первой точки A");
// double[] x1 = new double[3] {Convert.ToInt32(Console.ReadLine()), 
//                             Convert.ToInt32(Console.ReadLine()), 
//                             Convert.ToInt32(Console.ReadLine())};
// Console.WriteLine("Введите координаты X, Y, Z первой точки Б");
// double[] y2 = new double[3] {Convert.ToInt32(Console.ReadLine()),
//                             Convert.ToInt32(Console.ReadLine()),
//                             Convert.ToInt32(Console.ReadLine())};
// double firstOp = Math.Pow((y2[0] - x1[0]),2);
// double secondOp = Math.Pow((y2[1] - x1[1]),2);
// double thirdOp = Math.Pow((y2[2] - x1[2]),2);
// Console.WriteLine(Math.Round(Math.Sqrt((firstOp + secondOp + thirdOp)),2));



// Напишите программу, которая принимает на вход число (N) и 
// выдаёт таблицу кубов чисел от 1 до N.
// 3 -> 1, 8, 27
// 5 -> 1, 8, 27, 64, 125


// Console.Clear();
// Console.Write("Введите N: ");
// int n = Convert.ToInt32(Console.ReadLine());
// int i = 1;
// while (i < n)
// {
//     Console.WriteLine($"{Math.Pow((i),3)}, ");
//     i++;
// }