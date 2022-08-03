//Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.//

Console.Write("Введите число: ");

int inputNumber = int. Parse(Console.ReadLine());

void VariamtSimple()
{
    int sumOfNumbers = 0;                            // Создаём накопитель
    for(int i = 1; i<=inputNumber; i++)
    {
        sumOfNumbers+= i;
        //sumOfNumbers = sumOfNumbers = i;          // Это эквивалентно (sumOfNumbers+= i;)
    }
    Console.WriteLine("Сумма чисел от 1 до " + inputNumber + " = " + sumOfNumbers);

}
//VariamtSimple();

void VariamtGauss()            // Метод решает туже задачу (Аналитически) через формулу Гаусса
{
    int sumOfNumbers = 0;       // Создаём накопитель
    sumOfNumbers =  ((1+inputNumber)*inputNumber)/2;

    Console.WriteLine("Сумма чисел от 1 до " + inputNumber + " = " + sumOfNumbers);
}

VariamtGauss();
