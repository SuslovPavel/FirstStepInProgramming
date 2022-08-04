//Напишите программу, которая принимает на вход число (А) и выдаёт сумму чисел от 1 до А.//

Console.Write("Введите число: ");

int inputNumber = int. Parse(Console.ReadLine());
int t;

void VariamtSimple()
{
    long sumOfNumbers = 0;                            // Создаём накопитель
    for(int i = 1; i<=inputNumber; i++)
    {
        sumOfNumbers+= i;
        //sumOfNumbers = sumOfNumbers = i;          // Это эквивалентно (sumOfNumbers+= i;)
    }
    Console.WriteLine("Сумма чисел от 1 до " + inputNumber + " = " + sumOfNumbers);

}


void VariamtGauss()             // Метод решает туже задачу (Аналитически) через формулу Гаусса
{
    long sumOfNumbers = 0;       // Создаём накопитель
    sumOfNumbers =  ((1+inputNumber)*inputNumber)/2;      // Формула Гаусса - считае суммму от 1 до инпутНамбер

    Console.WriteLine("Сумма чисел от 1 до " + inputNumber + " = " + sumOfNumbers);
}

t = Environment.TickCount;      // Считает системное время компьютера

VariamtSimple();
Console.WriteLine("Simple time: {0} ms",Environment.TickCount - t);  // считает время выполнения метода
VariamtGauss();
Console.WriteLine("Gausse time: {0} ms",Environment.TickCount - t);