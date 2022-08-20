//  Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.
//  Пример: [345, 897, 568, 234] -> 2
//          [845, 222, 367, 123] -> 1


int[] FillingArrey()  //  Метод возвращает массив заполняя случайными числами
{
    int[] outArray = new int[30];                            // создаём переменную, выделяем память под неё, задаём длину массива 30 элементов
    int i = 0;                                               // индекс массива
    System.Random numberSintezator = new System.Random();    // создаём синтезатор случайных чисел, выделяем под него память
    while (i < 30)                                           // Цикл заполняет массив
    {
        outArray[i] = numberSintezator.Next(100,1000);       // Запускает синтезатор в границах от 100 до 1000
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

int CalculateTask(int[] outArrey) // принимает массив который заполнен в предыдущем методе "int [] FillingArrey()"
{
    int i = 0;
    int evenNumber = 0;                                    //  переменная для подсчёта чётных чисел
    while (i < outArrey.Length)                                         //  ограничивает цикл 30тью итерациями
    {
        if (outArrey[i]%2 == 0)                             // ищет чётные значения
        {
            evenNumber++;                                  // сумирует чётные значения массива  
        }   
        i++;
    }
    return evenNumber;
    
}

int[] bufferArray = FillingArrey();                      // заполняет массив
PrintIntArray(bufferArray);                              // печатает массив        
Console.Write("количество чётных чисел: " + CalculateTask(bufferArray));  // Запускает метод CalculateTask, закладывая переменную в bufferArray