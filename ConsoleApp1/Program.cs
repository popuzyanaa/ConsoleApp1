/////задание 1
//using System.Numerics;
//double a;
//double b;
//double total;
//double oper;

//Console.WriteLine("Введите первое число ");
//a = Convert.ToDouble (Console.ReadLine());

//Console.WriteLine("Выберите действие:+ знак сложения - - знак вычитания / знак деления * знак умножения");
//oper = Convert.ToChar (Console.ReadLine());

//Console.WriteLine("Введите второе число ");
//b = Convert.ToDouble(Console.ReadLine());

//    if (oper  == '+' )
//{
//    total = a + b;
//        Console.WriteLine("Сложение" + a + "и" + b + "равно" + total + ".");
//}
//else if (oper == '-' )
//        {
//    total = a - b;
//    Console.WriteLine("вычитание" + a + "и" + b + "равно" + total + ".");
//}
//else if (oper == '/')
//{
//    total = a / b;
//    Console.WriteLine("Деление" + a + "и" + b + "равно" + total + ".");
//}
//else if (oper == '*')
//{
//    total = a * b;
//    Console.WriteLine("Умножение" + a + "и" + b + "равно" + total + ".");
//}

//задание 2

//Console.WriteLine("Введите строку:");
//string input = Console.ReadLine();

//int charCount = input.Length;
//int wordCount = input.Split(new char[] { ' ', '.', ',', '!', '?' }, StringSplitOptions.RemoveEmptyEntries).Length;
//int sentenceCount = input.Split(new char[] { '.', '!', '?' }, StringSplitOptions.RemoveEmptyEntries).Length;

//Console.WriteLine($"Количество символов: {charCount}");
//Console.WriteLine($"Количество слов: {wordCount}");
//Console.WriteLine($"Количество предложений: {sentenceCount}");



////задание 3
//int[,] mas = new int[10, 10];


//for (int i = 1; i < 10; i++)
//{
//    for (int j = 1; j < 10; j++)
//    {
//        mas[i, j] = i * j;
//        Console.Write("{0}\t", mas[i, j]);
//    }
//    Console.WriteLine();
//}
//Console.ReadKey();

/////задание 4
//int s;
//int F = 1;
//Console.WriteLine("Введите число");
//s = int.Parse(Console.ReadLine());

//for (int c = s; c > 1; c--)
//    F = F * c;
//Console.WriteLine("Факториал  = " + F);
//Console.ReadLine();



////задание 5
//Console.WriteLine("Введите количество чисел ряда Фибоначчи:");
//int n = Convert.ToInt32(Console.ReadLine());
//int a = 0, b = 1;
//for (int i = 0; i < n; i++)
//{
//    Console.Write(a + " ");
//    int temp = a;
//    a = b;
//    b = temp + b;
//}

////задание 6
//int n = Convert.ToInt32(Console.ReadLine());
//int count = 0;
//for (int i = 1; i < n; i++)
//{
//    count = 0;
//    for (int j = 1; j < n; j++)
//    {
//        if (i % j == 0) count++;
//    }
//    if (count == 2) Console.WriteLine(i);
//}



////задание 7

//Random r = new Random();
//int a = r.Next(1, 101);
//int b = Convert.ToInt32(Console.ReadLine());
//if (a == b)
//{
//    Console.WriteLine("победа");
//}
//else
//{
//    Console.WriteLine($"лох ");
//}




////задание 8
//Console.WriteLine("калькулятор площади фигур");
//string figure = Console.ReadLine();
//if (figure == "круг")
//{
//    int r = int.Parse(Console.ReadLine());
//    Console.WriteLine( "площадь круга равна"+ (3, 14 * (r *r)));
//}
//if (figure == "треугольник")
//{
//    int a = int.Parse(Console.ReadLine());
//    int b = int.Parse(Console.ReadLine());
//    Console.WriteLine("площадь треугольника равна" + (1 / 2 * a * b));
//}
//if (figure == "прямоугольник")
//{
//    int c = int.Parse(Console.ReadLine());
//    int d = int.Parse(Console.ReadLine());
//    Console.WriteLine("площадь  прямоугольника равна" + c*d);
//}


////задание 9
Console.Write("Введите метры в километры: ");
double m = double.Parse(Console.ReadLine());
Console.Write("Введите килограммы в граммы: ");
double p = double.Parse(Console.ReadLine());
Console.WriteLine("Шо хочешь?\n1.гр\n2. км");
int sel = int.Parse(Console.ReadLine());

switch (sel)
{
    case 2: Console.WriteLine($"{p * 0.001d} кг"); break;
    case 1: Console.WriteLine($"{m * 0.001d} км"); break;
}
