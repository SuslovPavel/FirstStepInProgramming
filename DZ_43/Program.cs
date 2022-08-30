//  Напишите программу, которая найдёт точку пересечения двух прямых, 
//  заданных уравнениями y = k1 * x + b1, y = k2 * x + b2; 
//  значения b1, k1, b2 и k2 задаются пользователем.  
//  Пример : b1 = 2, k1 = 5, b2 = 4, k2 = 9 -> (-0,5; 5,5)

double b1;   // глобальная переменная, необходима т.к. переменные внутри метода не видны (тип данных внутри метода уже не указывается)
double b2;
double k1;
double k2;
double x;
double y;

void ReadMethod()
{
    Console.WriteLine("Введите значение b1");                // Выводит сообщение на консоль
    b1 = double.Parse(Console.ReadLine()?? "");              // Распознаёт введёное значение

    Console.WriteLine("Введите значение b2");
    b2 = double.Parse(Console.ReadLine()?? "");

    Console.WriteLine("Введите значение k1");
    k1 = double.Parse(Console.ReadLine()?? "");

    Console.WriteLine("Введите значение k2");
    k2 = double.Parse(Console.ReadLine()?? "");
}

void ConculateMethod()
{
    x =  (b2-b1)/(k1-k2);             // формула для нахождения координат пересечения двух прямых
    y = k1*((b2-b1)/(k1-k2))+b1;      // формула для нахождения координат пересечения двух прямых
}

void PrintMethod()  //  Метод печатает результат
{
    Console.WriteLine($"({x} ; {y})");                 //Выводим элемент массива
}
                     

ReadMethod();
ConculateMethod();
PrintMethod();
 