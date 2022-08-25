// Не используя рекурсию, выведите первые N чисел Фибоначчи. Первые два числа Фибоначчи: 0 и 1.
// Например: Если N = 5 -> 0 1 1 2 3
//           Если N = 3 -> 0 1 1
//           Если N = 7 -> 0 1 1 2 3 5 8

Console.Write("Введите количество чисел в ряде Фибоначчи: ");
int decemalNumber = ReadDecemalNumber();
string outLine = Fibonnaci(decemalNumber);
PrintAnswer(outLine);

int ReadDecemalNumber()   // метод чтения с консоли
{
    return int.Parse(Console.ReadLine() ?? "");
}

string Fibonnaci(int n)
{
    string answer = "";          

    if (n == 2)
    {
        answer = "0 1";             // выдаёт "0 1" при введении 2
    }
    else if (n == 1)
    {
        answer = "0";              //  выдаёт "0 " при введении 1
    }
    else
    {
        answer = "0 1";            //  пр  введении >2 выдаёт сначала 0 1 последующие вычисляет по алгоритму ниже
        int fn_1 = 1;              // создаём переменные
        int fn_2 = 0;
        int fn;
        for (int i = 0; i < n - 2; i++)
        {
            fn = fn_1 + fn_2;        // вычисление числа фибаначчи
            answer += " " + fn;
            fn_2 = fn_1;
            fn_1= fn;
        }
    }
    return answer;
}

void PrintAnswer(string answer)
{
    Console.WriteLine("Ряд Фибоначчи для заданного кол-ва чисел: " + answer);
}