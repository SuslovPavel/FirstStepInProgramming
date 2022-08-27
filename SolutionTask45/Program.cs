// Напишите программу, которая будет создавать копию заданного одномерного массива с помощью поэлементного копирования.

int[] FillingArrey()  //  Метод возвращает массив заполняя случайными числами
{
    int[] outArray = new int[11];                            // создаём переменную, выделяем память под неё, задаём длину массива 12 элементов
    int i = 0;                                               // индекс массива
    System.Random numberSintezator = new System.Random();    // создаём синтезатор случайных чисел, выделяем под него память
    while (i < 11)                                           // Цикл заполняет массив
    {
        outArray[i] = numberSintezator.Next(-100,100);       // Запускает синтезатор в границах от -100 до 100
        i++;
    }
    return outArray;
}

void PrintIntArray(int[] inputArray)  //  Метод печатает массив
{
    int i = 0;
    while (i < inputArray.Length - 1)                       //Пробегаем все элементы массива       
    {
        Console.Write(inputArray[i] + ", ");                 //Выводим элемент массива
        i++;
    }
    Console.WriteLine(inputArray[i]);                        //Выводим элемент массива, строка необходима чтобы устранить запятую
}


int[] CopyArrayStandartTool(int[] inputArray)
{
    int[] buferArray = new int[inputArray.Length];
    inputArray.CopyTo(buferArray,0);  // Вызывается метод котторый копирует входящий массив в другой массив
    return buferArray;
}

int[] testArray =  FillingArrey();
PrintIntArray(testArray);

int[] Array2 = CopyArrayStandartTool(testArray);
PrintIntArray(Array2);