//  Пользователь вводит с клавиатуры M чисел. Посчитайте, сколько чисел больше 0 ввёл пользователь. 5 0, 7, 8, -2, -2 -> 2
void PrintArray(int[] Array)    
{
for (int i = 0; i < Array.Length-1; i++)
{
    Console.Write($"{Array[i]}, ");
}
Console.WriteLine(Array[Array.Length -1] );
}
int CountOfNumbers(int[] arr)
{
    int count=0;
    for (int i = 0; i < arr.Length; i++)
    {
        if(arr[i]>0) count++;
    }
    return count;
}
void Method()
{
    Console.Write("Сколько чисел вы введете: ");
    int M = Convert.ToInt32(Console.ReadLine());
    int[] myArray = new int[M];
    for (int i = 0; i < myArray.Length; i++)
        {
        Console.Write($"Введите число:\t ");
        myArray[i]= Convert.ToInt32(Console.ReadLine());
        }
    Console.Write("Вывод последовательности чисел: ");
    PrintArray(myArray);
    int countNumbers = CountOfNumbers(myArray);
    Console.WriteLine("Чисел в последовательности больше 0: " + countNumbers);
}
try
{
    Method();
}
catch 
{
    Console.WriteLine("Нужно вводить число ");
}

