// Напишите программу, которая принимает на вход число и выдаёт количество цифр в числе //

//Console.Clear();
Console.Write("Введите число: ");

string inputLineNumber = Console.ReadLine()??"";       //   (??"") избавляет от null    
int inputNumber = int.Parse(inputLineNumber);

int VariantChar()  // Метод возвращает int
{
    // int numberLength = 0;
    // char [] arrey = inputLineNumber.ToCharArray();    //  оператор преобразует число в массив
    // numberLength = arrey.Length;                      // вызывает длину массива
    // return numberLength;

            // Равнозначные стороки кода //

    return inputLineNumber.ToCharArray().Length;  //оператор берёт переменную преобразует её в массив и вызывает свойства Length                             
}

int VariantSimple()
{
    int numberLength = 0;
    int digits = 1;
    while (digits < inputNumber)
    {
        digits = digits * 10;
        numberLength++;
    }
    return numberLength;
}

int VariantLog10()
{
    return (int)Math.Log10(inputNumber)+1;   // вызывает логорифм 10ти введёного числа,(int) принудительно преобразовывает в инт
}

int result = 0;              //  кладёт в result переменную int
result = VariantChar();        
Console.WriteLine(result);

result = VariantSimple();        
Console.WriteLine(result);

result =VariantLog10();        
Console.WriteLine(result);