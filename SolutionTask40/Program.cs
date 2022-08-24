// Напишите программу, которая принимает на вход три числа и проверяет, может ли существовать треугольник с сторонами такой длины.

int sideA =0;
int sideB =0;
int sideC =0;

void ReadSides()  // метод принимает знечения с консоли
{
    Console.Write("Введите число 1: ");
    sideA = int.Parse(Console.ReadLine() ??"");
    Console.Write("Введите число 2: ");
    sideB = int.Parse(Console.ReadLine() ??"");
    Console.Write("Введите число 3: ");
    sideC = int.Parse(Console.ReadLine() ??"");
}

bool TestTriangle()   // метод производит вычисления
{
    bool answer = ((sideA + sideB > sideC))&&   // Тринарный оператор, проверяет условие и выдает результат в переменную answer
                   (sideB + sideC > sideA)&&
                   (sideC + sideA > sideB)? true: false;
    return answer;
}

void PrintAnswer(bool answer)  // Метод для печати, принимает знечения с метода TestTriangle
{
    if (answer)
    {
        Console.WriteLine("Из этих отрезков МОЖНО составить треугольник");
    }
    else
    {
        Console.WriteLine("Из этих отрезков НЕЛЬЗЯ составить треугольник");
    }
}

ReadSides();
bool res = TestTriangle();
PrintAnswer(res);