//  Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях.
//  Пример: [3, 7, 23, 12] -> 19
//          [3, 7, -2, 1] -> 8
//          [-4, -6, 89, 6] -> 0

int[] FillingArrey()  //  Метод возвращает массив заполняя случайными числами
{
    int[] outArray = new int[8];                            // создаём переменную, выделяем память под неё, задаём длину массива 8 элементов
    int i = 0;                                               // индекс массива
    System.Random numberSintezator = new System.Random();    // создаём синтезатор случайных чисел, выделяем под него память
    while (i < 8)                                           // Цикл заполняет массив
    {
        outArray[i] = numberSintezator.Next(-99, 100);       // Запускает синтезатор в границах от -99 до 100
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

int CalculateTask(int[] outArrey)  // принимает массив который заполнен в предыдущем методе "int [] FillingArrey()"
{
    int i = 0;
    int result = 0;                                    //  переменная для подсчёта элементов на чётных позициях массива
    while (i < outArrey.Length)                        //  ограничивает цикл длиною массива
    {
        if ((i) % 2 != 0)                                // ищет чётные позиции массива
        {
            result += outArrey[i];                       // сумирует элементы стоящие на чётных позициях массива  
        }
        i++;
    }
    return result;
}

int MethodSimple(int[] outArrey)  // принимает массив который заполнен в предыдущем методе "int [] FillingArrey()"
{
    int i = 1;
    int sum = 0;                                    //  переменная для подсчёта элементов на чётных позициях массива
    while (i < outArrey.Length)                     //  ограничивает цикл длиною массива
    {
        sum = sum + outArrey[i];                    //  сумирует элементы на чётных позициях
        i+=2;                                       //  икримент (+2) позволяющий пропустить элементы массива не чётных позиций 
    }
    return sum;
}
    


int[] bufferArray = FillingArrey();                      // заполняет массив
PrintIntArray(bufferArray);                              // печатает массив        
Console.Write("сумма значений на чётных позициях массива=  " + CalculateTask(bufferArray));  // Запускает метод CalculateTask, закладывая переменную в bufferArray
Console.WriteLine();
Console.Write("сумма значений на чётных позициях массива=  " + MethodSimple(bufferArray));   // Запускает метод MethodSimple, закладывая переменную в bufferArray