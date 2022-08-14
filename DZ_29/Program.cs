// Напишите программу, которая задаёт массив из 8 элементов и выводит их на экран.


System.Random numberSintezator = new Random();  // Создаём: Рандомайзер, глобальную переменную, выделяем под него память (new)
Console.Write("Ведите число равное длине массива: ");
string inputNumber = Console.ReadLine()?? "";
int lengthArrey = int.Parse(inputNumber);       // принимает число с консоли, распознает его, и  конвертирует в длину массива
int i = 0;


void VariantNaive()
{
    //int i = 0;
    Console.Write("[");                                // выводит скобку
    while(i<(lengthArrey-1))                           // задает длину массива
    {
        Console.Write(numberSintezator.Next(0,11)+","); // выводит случайное число от 0 до 10
        i++;       
    }
    Console.Write(numberSintezator.Next(0,11));        // выводит последнее случайное число от 0 до 10
    Console.Write("]");                               // выводит скобку

}
VariantNaive();

