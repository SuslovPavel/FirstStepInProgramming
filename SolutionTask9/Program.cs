System.Random numberSintezator = new Random ();
int number = numberSintezator.Next(10,100);
Console.WriteLine(number);
// Вариант 1
int firstNumber = number/10;
int secondNumber = number%10;

if (firstNumber>secondNumber)
{
    Console.WriteLine(firstNumber);
}
else
{
    Console.WriteLine(secondNumber);
}

// Вариант 2

int NumberK =new Random().Next(10,100);
Console.Write ("The Random number is: ");
Console.WriteLine (NumberK);

string stringNumber = NumberK.ToString();
Console.Write ("the Biggest digit is: ");
if(stringNumber[0]>stringNumber[1])
{
    Console.WriteLine(stringNumber[0]);
}
else
{
    Console.WriteLine(stringNumber[1]);
}

// Вариант 3

char[] digits = numberSintezator.Next(10,100).ToString().ToCharArray();
Console.WriteLine(digits);

firstNumber = ((int)digits[0])-48;
secondNumber = ((int)digits[1])-48;

int resulteNember = firstNumber>secondNumber?resulteNember=firstNumber:resulteNember=secondNumber;
Console.WriteLine(resulteNember);