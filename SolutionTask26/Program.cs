// Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе //

//Console.Clear();
Console.Write("Введите число: ");

string inputLineNumber = Console.ReadLine()??"";       //   (??"") избавляет от null    
long inputNumber = long.Parse(inputLineNumber);

DateTime timePoint = DateTime.Now;                    // Вводим переменую для замера времени выполнения кода

long VariantChar()  // Метод возвращает int
{
    // int numberLength = 0;
    // char [] arrey = inputLineNumber.ToCharArray();    //  оператор преобразует число в массив
    // numberLength = arrey.Length;                      // вызывает длину массива
    // return numberLength;

            // Равнозначные стороки кода //

    return inputLineNumber.ToCharArray().Length;  //оператор берёт переменную преобразует её в массив и вызывает свойства Length                             
}

long VariantSimple()
{
    long numberLength = 0;
    long digits = 1;
    while (digits < inputNumber)
    {
        digits = digits * 10;
        numberLength++;
    }
    return numberLength;
}

long VariantLog10()
{
    return (long)Math.Log10(inputNumber)+1;   // вызывает логорифм 10ти введёного числа,(int) принудительно преобразовывает в инт
}

long result = 0;              //  кладёт в result переменную int

timePoint = DateTime.Now;    
result = VariantChar();        
Console.WriteLine(result);
Console.WriteLine(DateTime.Now-timePoint);      //  расчитывает время выполнения метода и выводит результат на консоль

timePoint = DateTime.Now;
result = VariantSimple();        
Console.WriteLine(result);
Console.WriteLine(DateTime.Now-timePoint);

timePoint = DateTime.Now;
result =VariantLog10();        
Console.WriteLine(result);
Console.WriteLine(DateTime.Now-timePoint);