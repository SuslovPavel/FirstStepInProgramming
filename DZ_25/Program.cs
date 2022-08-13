//   Напишите цикл, который принимает на вход два числа (A и B) и возводит число A в натуральную степень B

Console.Write("Введите число: ");                               // Принимает значение с консоли, уберает null, расрлзнает значение
string inputLineNumberA = Console.ReadLine() ?? "";
int inputNumberA = int.Parse(inputLineNumberA);

Console.Write("В какую степень возвести число: " + (inputNumberA) + "? ");
string inputLineNumberB = Console.ReadLine() ?? "";
int inputNumberB = int.Parse(inputLineNumberB);



void Calculate()
{

    int i = 0;
    int numC = 1;
    while (i < inputNumberB)                           // Повторяет цикл количество раз inputNumberB
    {
        numC = (numC * inputNumberA);                  // Перемножает введёные данные
        i++;
    }
    Console.WriteLine(numC);
}

Calculate();

  //   АНДРЕЙ подскажите пожалуйста как обернуть в метод верхний блок кода, необходимый для ввода данных, я как не пытался ерунда выходит  //
                                //  Заранее благодарю  //

