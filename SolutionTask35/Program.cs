//  Задайте одномерный массив из 123 случайных чисел. Найдите количество элементов массива, значения которых лежат в отрезке [10,99].
// Пример для массива из 5, а не 123 элементов. В своем решении сделайте для 123
//                                                                              [5, 18, 123, 6, 2] -> 1
//                                                                              [1, 2, 3, 6, 2] -> 0
//                                                                              [10, 11, 12, 13, 14] -> 5

int[] FillingArrey()  // Метод возвращает массив заполняя случайными числами
{
    int[] outArray = new int[123];                           // создаём переменную, выделяем память под неё, задаём длину массива 123 элементов
    int i = 0;                                               // индекс массива
    System.Random numberSintezator = new System.Random();    // создаём синтезатор случайных чисел, выделяем под него память
    while (i < 123)                                          // Цикл заполняет массив
    {
        outArray[i] = numberSintezator.Next(-1000,1000);         // Запускает синтезатор в границах от 0 до 1000
        i++;
    }
    return outArray;
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

int CalculateTask(int[] inputArray, int downBorder, int upBorder)  // Метод ищет заданный эл-т в массиве
{
    int resultCount = 0;                                  // Cоздаём переменную
    int i = 0;
    while(i<inputArray.Length)                            // применяет вычисления по всей длине массива
    {
        if (inputArray[i] >= downBorder && inputArray[i] <= upBorder)                     // проверяет эл-т  массива в заданной границе
        {
            Console.Write(inputArray[i]+" ");
            resultCount++;                                       // подсчитывает кол-во подходящих эл-ов
        }
        i++;
    }
    return resultCount;
}

int[] bufferArray = FillingArrey();                      // заполняет массив
PrintIntArray(bufferArray);                              // печатает массив
Console.Write(CalculateTask(bufferArray,10,99));     // вызывает метод и задаёт граници искомых чисел