// Напишите программу, которая выводит массив из 8 элементов, заполненный нулями и единицами в случайном порядке.
//Например: [1,0,1,1,0,1,0,0]

System.Random numberSintezator = new Random();  // Создаём: Рандомайзер, глобальную переменную, выделяем под него память (new)

void VariantNaive()
{
    int i = 0;
    Console.Write("[");                                // выводит скобку
    while(i<7)
    {
        Console.Write(numberSintezator.Next(0,2)+","); // выводит случайное число от 0 до 1
        i++;       
    }
    Console.Write(numberSintezator.Next(0,2));        // выводит последнее случайное число от 0 до 1
    Console.Write("]");                               // выводит скобку

}
VariantNaive();