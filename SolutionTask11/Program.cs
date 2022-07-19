//Вариант 1

void variant1()
{
    int NumberK = new Random().Next(100, 1000);
    Console.Write("The Random number is: ");
    Console.WriteLine(NumberK);

    string stringNumber = NumberK.ToString();
    Console.Write("The foud number is: ");
    Console.Write(stringNumber[0]);
    Console.WriteLine(stringNumber[2]);
        
}

// Вариант 2

void variant2()
{
    int Number = new Random().Next(100, 1000);
    Console.Write("The Random number is: ");
    Console.WriteLine(Number);

    int num1 = Number/100;
    int num2 = Number%10;

    Console.Write("The Modified num is: ");
    Console.Write(num1*10+num2);
    

}


variant1();

variant2();