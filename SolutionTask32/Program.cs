//  Напишите программу замена элементов массива: положительные элементы замените на соответствующие отрицательные, и наоборот.
//  Пример: [-4, -8, 8, 2] -> [4, 8, -8, -2]

int[] FillingArrey() // Метод возвращает массив заполняя случайными числами от -9 до 9
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


int[] CalculateTask(int[] inputArray)      // метод инвертирует элементы массива
{
    int[] outputArray = new int[12];                        // создаём переменную, выделяем память под неё, задаём длину массива 12 элементов
    int i = 0;
    while (i < 12)                                          // ограничивает цикл 12тью итерациями
    {
        outputArray[i] = inputArray[i] * (-1);
        i++;
    }
    return outputArray;
}


void PrintIntArray(int[] inputArray)       //Метод печатает массив
{
    int i = 0;
    while (i < inputArray.Length - 1)                       //Пробегаем все элементы массива       
    {
        Console.Write(inputArray[i] + ", ");                 //Выводим элемент массива
        i++;
    }
    Console.WriteLine(inputArray[i]);                        //Выводим элемент массива, строка необходима чтобы устранить запятую
}

int[] InvertArrayTilda(int[] inputArray)   //  Метод инвертирует значения бинарной операцией Tilda
{
    int i = 0;
    while (i < inputArray.Length)
    {
        inputArray[i] = (~inputArray[i]) + 1;   //бинарная операция Tilda инвертирует значения
        i++;
    }
    return inputArray;                         // Выводит массив
}

int[] bufferArray = FillingArrey();
PrintIntArray(bufferArray);
int[] resultArray = CalculateTask(bufferArray);
PrintIntArray(resultArray);
resultArray = InvertArrayTilda(bufferArray);
PrintIntArray(resultArray);

