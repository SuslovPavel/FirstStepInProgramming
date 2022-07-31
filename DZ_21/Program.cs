



int coordXPointA;  // глобальная переменная, необходима т.к. переменные внутри метода не видны (тип данных внутри метода уже не указывается)
int coordYPointA;
int coordZPointA;
int coordXPointB;
int coordYPointB;
int coordZPointB;
double LengthAB;

// Считывает координаты точек А и В
void readDataOfPoint()
{
    Console.WriteLine("Введите коордигату Х точки А");         // Выводит сообщение на консоль
    coordXPointA = int.Parse(Console.ReadLine());              // Распознаёт введёное значение

    Console.WriteLine("Введите коордигату Y точки А");
    coordYPointA = int.Parse(Console.ReadLine());

    Console.WriteLine("Введите коордигату Z точки А");
    coordZPointA = int.Parse(Console.ReadLine());

    Console.WriteLine("Введите коордигату Х точки B");
    coordXPointB = int.Parse(Console.ReadLine());

    Console.WriteLine("Введите коордигату Y точки B");
    coordYPointB = int.Parse(Console.ReadLine());

    Console.WriteLine("Введите коордигату Z точки B");
    coordZPointB = int.Parse(Console.ReadLine());
}

// Вычисляет расстояние между точками А и В
void conculateLengthAB()
{
           // мат. действие извлечение корня                      // мат. действие возведение в степень
LengthAB = Math.Sqrt(Math.Pow((coordXPointA - coordXPointB), 2) + Math.Pow((coordYPointA - coordYPointB), 2) + Math.Pow((coordZPointA - coordZPointB), 2));  // тип double хранит значения с запятыми
}

readDataOfPoint();      // Активация метода
conculateLengthAB();

Console.WriteLine(LengthAB);