//Напишите программу, которая принимает на вход координаты точки (X и Y),
// причём X ≠ 0 и Y ≠ 0 и выдаёт номер четверти плоскости, 
//в которой находится эта точка.
// Пример: x=34; y=-30 -> 4

//===Метод 1 Считывает точки и возвращает массив с ними===//
int[,] readPoint()
{
    string inputLine = Console.ReadLine();


    string coordXLine =  inputLine.Substring(0,inputLine.IndexOf(";"));   // Берёт значение от 0 до ; и кладёт в значение coordX (Substring - выделяет подстроку)
    coordXLine = coordXLine.Substring(coordXLine.IndexOf("=")+1);         // Отрезает значение от = до ;

    string coordYLine =  inputLine.Substring(inputLine.IndexOf(";")+1);   
    coordYLine = coordYLine.Substring(coordYLine.IndexOf("=")+1);

    //Console.WriteLine(coordX+" "+coordY);                           // выводит координаты на консоль, введёные на консоле
    //return new int[1,1];                                            // возвращаем пустой массив

    int coordX = int.Parse(coordXLine);                             // заробрали значение, распарсили   
    int coordY = int.Parse(coordYLine);

    int[,] arrayOut = new int[1,2];                               // создаёт массив в виде таблици из 1ой стороки и 2х столбцов
    arrayOut[0,0]=coordX;                                             
    arrayOut[0,1]=coordY;                                          // заполняет таблицу

    return arrayOut;

}

//===Метод 2 Печатает номер четверти===//
void printQuter(int[,] arreyPoint)
{
    if(arreyPoint[0,0]>0&&arreyPoint[0,1]>0)
    Console.WriteLine("1 четверть");

    if(arreyPoint[0,0]<0&&arreyPoint[0,1]>0)
    Console.WriteLine("2 четверть");

    if(arreyPoint[0,0]<0&&arreyPoint[0,1]<0)
    Console.WriteLine("3 четверть");

    if(arreyPoint[0,0]>0&&arreyPoint[0,1]<0)
    Console.WriteLine("4 четверть");

}

int[,] arreyPoint = readPoint();        // создаём переменую массив, считываем точки

printQuter(arreyPoint);

//printQuoter(readPoint()); // альтернативный способ вызова метода