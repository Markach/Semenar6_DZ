// Напишите программу, которая найдёт точку пересечения двух прямых, заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
//значения b1, k1, b2 и k2 задаются пользователем. b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; -0,5)
double FindX(double b1, double b2, double k1, double k2) 
{  
    double x=(b1-b2)/(k2-k1);  return x;
}
double FindY(double b1, double b2, double k1, double k2)
{  
    double y=(k2*b1-k1*b2)/(k2-k1); return y;
}
void Method()
{
Console.Write("Введите число, значение b1: ");
double b1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите число, значение k1: ");
double k1 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите число, значение b2: ");
double b2 = Convert.ToDouble(Console.ReadLine());
Console.Write("Введите число, значение k2: ");
double k2 = Convert.ToDouble(Console.ReadLine());

    if ((k1==k2) & (b1==b2)) 
    {
    Console.Write ("прямые совпадают ");
    }
        else if (k1==k2) 
        {
        Console.Write("прямые параллельны ");
        }
            else 
            {
            double point1 =FindX(b1, b2, k1, k2);
            double point2 =FindY(b1, b2, k1, k2);
            Console.WriteLine($"Пересечение в точке: ({point1};{point2})");
            }
}            
try
{
    Method();
}
catch 
{
    Console.WriteLine("Нужно вводить число ");
}