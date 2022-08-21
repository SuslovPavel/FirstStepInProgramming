//  Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
//  Пример: [345, 897, 568, 234] -> 2
//          [845, 222, 367, 123] -> 1
// +  метод пузырьковой сортировки 

int[] FillingArrey()  //  Метод возвращает массив заполняя случайными числами
{
    int[] outArray = new int[28];                            // создаём переменную, выделяем память под неё, задаём длину массива 30 элементов
    int i = 0;                                               // индекс массива
    System.Random numberSintezator = new System.Random();    // создаём синтезатор случайных чисел, выделяем под него память
    while (i < 28)                                           // Цикл заполняет массив
    {
        outArray[i] = numberSintezator.Next(100, 1000);       // Запускает синтезатор в границах от 100 до 1000
        i++;
    }
    return outArray;
}

int[] BubbleSort(int[] outArrey)  // Метод пузырьковой сортировки
{
    int temp = 0;
    for (int i = 0; i < outArrey.Length - 1; i++)       // проходим весь массив
    {
        for (int j = i + 1; j < outArrey.Length; j++)   // создаём эл-т с которым будем сравнивать эл-ты массива
        {
            if (outArrey[i] > outArrey[j])              // условия для замены эл-ов
            {
                temp = outArrey[i];                     // меняем эл-ты местами
                outArrey[i] = outArrey[j];
                outArrey[j] = temp;
            }
        }
    }
    for (int i = 0; i < outArrey.Length; i++)
    {
        Console.Write(outArrey[i] + ", ");
    }
    return outArrey;
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

int CalculateTask(int[] outArrey) // принимает массив который заполнен в предыдущем методе "int [] FillingArrey()"
{
    int i = 0;
    int evenNumber = 0;                                    //  переменная для подсчёта чётных чисел
    while (i < outArrey.Length)                                         //  ограничивает цикл 30тью итерациями
    {
        if (outArrey[i] % 2 == 0)                             // ищет чётные значения
        {
            evenNumber++;                                  // сумирует чётные значения массива  
        }
        i++;
    }
    return evenNumber;

}



int[] bufferArray = FillingArrey();                      // заполняет массив
Console.Write("исходный массив - ");
PrintIntArray(bufferArray);                              // печатает массив  
Console.Write("отсортированный массив - ");
Console.WriteLine(BubbleSort(bufferArray));              // Метод пузырьковой сортировки
Console.WriteLine("количество чётных чисел: " + CalculateTask(bufferArray));  // Запускает метод CalculateTask, закладывая переменную в bufferArray

  // АНДРЕЙ подскажите пожалуйста: после запуска программы на консоль выводится " System.Int32[] " -  как от этого избавится 