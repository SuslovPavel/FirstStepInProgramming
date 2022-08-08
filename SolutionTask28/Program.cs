
// Напишите программу, которая принимает на вход число N и выдаёт произведение чисел от 1 до N.

Console.Write("Введите число: ");
string? inputLine = Console.ReadLine()??"";
long inputNum = int.Parse(inputLine);

//Console.WriteLine(sumNums(inputNum));      // Вызывает метод и выводит результат на консоль
//Console.WriteLine(mulRec(inputNum));       // Вызывает метод и выводит результат на консоль
long sumNums(long num)
{
    long sum = 1;
    for (long i = 1; i <= inputNum; i++ )
    {
        //  sum *=i;
        sum = sum*i;
    }
    return sum;
}
Console.WriteLine(sumNums(inputNum));    // Вызывает метод и выводит результат на консоль


long mulRec(long num)         //  Метод с рекурсией  //
{
    if(num==1)
    {
        return 1;
    }
    else
    {
        return num * mulRec(num- 1);
    }
}
Console.WriteLine(mulRec(inputNum));    // Вызывает метод и выводит результат на консоль