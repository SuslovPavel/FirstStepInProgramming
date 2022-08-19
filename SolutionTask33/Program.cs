//Задайте массив. Напишите программу, которая определяет, присутствует ли заданное число в массиве.
//Например: 4; массив [6, 7, 19, 345, 3] -> нет
//         -3; массив [6, 7, 19, 345, 3] -> да

int[] FillingArrey()  // Метод возвращает массив заполняя случайными числами от -9 до 9
{
    int[] outArray = new int[12];                           // создаём переменную, выделяем память под неё, задаём длину массива 12 элементов
    int i = 0;                                              // индекс массива
    System.Random numberSintezator = new System.Random();   // создаём синтезатор случайных чисел, выделяем под него память
    while (i < 12)                                          // Цикл заполняет массив
    {
        outArray[i] = numberSintezator.Next(-9, 10);        // Запускает синтезатор в промежутке от -9 до 10
        i++;
    }
    return outArray;
}

bool CalculateTask(int[] inputArray, int serchNumber)  // Метод ищет заданный эл-т в массиве
{
    
    bool resultSearch = false;                               // Cоздаём переменную для типа bool
    int i = 0;
    while(i<12)
    {
        if (inputArray[i]==serchNumber)                     // ищет заданный эл-т в массиве
        {
            resultSearch = true;
            break;                                         // прерывает поиски в случае находки заданого эл-та
        }
        i++;
    }
    return resultSearch;
}

void PrintIntArray(int[] inputArray)  //Метод печатает массив
{
    int i = 0;
    while (i < inputArray.Length - 1)                       //Пробегаем все элементы массива       
    {
        Console.Write(inputArray[i] + ", ");                 //Выводим элемент массива
        i++;
    }
    Console.WriteLine(inputArray[i]);                        //Выводим элемент массива, строка необходима чтобы устранить запятую
}

int[] bufferArray = FillingArrey();
PrintIntArray(bufferArray);
Console.WriteLine("Введите число для поиска: ");
int serchNumber = int.Parse(Console.ReadLine()??"");
Console.WriteLine(CalculateTask(bufferArray,serchNumber));


