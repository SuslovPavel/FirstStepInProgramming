// Напишите программу, которая будет преобразовывать десятичное число в двоичное.
// Например: 45 -> 101101    3 -> 11    2 -> 10

Console.WriteLine(Convert.ToString(int.Parse(Console.ReadLine()?? ""), 2) );   //программа переводит десятичное число в двоичное

int number = int.Parse(Console.ReadLine() ?? "");  // принимает значение с консоли и распознаёт его
string outLine = Convert.ToString(number, 8);     // конвертирует принятое значение в выбраную систему исчисления (в данном случае в восьмиричную)
Console.WriteLine(outLine);                      // печатает рузультат 



int ReadDecemalNumber()  
{
    return int.Parse(Console.ReadLine() ?? "");
}

string BinaryConverter(int num)
{
    string bin = "";
    while (num > 0)
    {
        if (num % 2 == 1)
        {
            bin = "1" + bin;
        }
        else
        {
            bin = "0" + bin;
        }
        num /= 2;
    }
    return bin;
}

void PrintAnswer(string answer)
{
    Console.WriteLine("Введенное число в двоичном виде: " + answer);
}


Console.Write("Введите десятичное число: ");
int decemalNumber = ReadDecemalNumber();
PrintAnswer(BinaryConverter(decemalNumber));