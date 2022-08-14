
// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе. //


Console.Write("Введите число: ");
string inputLineNumberA = Console.ReadLine() ?? "";
long numberA = int.Parse(inputLineNumberA);
long numberB = 0;
long i = 0;
long resulte = 0;

DateTime timePoint = DateTime.Now;                     // Вводим переменую для замера времени выполнения метода


long MethodInt()
{
    while (numberA > 0)
    {
        numberB = numberB + (numberA % 10);            // накапливает остатки от деления
        numberA = numberA / 10;                        // уменьшает введёное число для повтора цикла
    }
    return numberB;
}


long MethodMLength()
{
    char[] M = inputLineNumberA.ToCharArray();

    while (i < M.Length)
    {
        resulte = resulte + M[i] - 48;               // накапливает значения из массива
        i++;
    }
    return resulte;
}

timePoint = DateTime.Now;    
numberB = MethodInt();        
Console.WriteLine(numberB);
Console.WriteLine(DateTime.Now-timePoint);

timePoint = DateTime.Now;    
resulte = MethodMLength();        
Console.WriteLine(resulte);
Console.WriteLine(DateTime.Now-timePoint);