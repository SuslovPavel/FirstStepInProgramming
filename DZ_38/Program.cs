//  Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементов массива.
//  Пример: [3 7 22 2 78] -> 76



int[] FillingArrey()  //  Метод возвращает массив заполняя случайными числами
{
    int[] outArray = new int[8];                            // создаём переменную, выделяем память под неё, задаём длину массива 8 элементов
    int i = 0;                                               // индекс массива
    System.Random numberSintezator = new System.Random();    // создаём синтезатор случайных чисел, выделяем под него память
    while (i < 8)                                           // Цикл заполняет массив
    {
        outArray[i] = numberSintezator.Next(0,100);       // Запускает синтезатор в границах от 0 до 100
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
    int max = 0;                                       //  переменная для максимального значения
    int min = int.MaxValue;                            //  переменная для минимального значения ( команда int.MaxValue ищет максимальное значение)
    int difference = 0;                                //  переменная для подсчёта разници между max и min
    while (i < outArrey.Length)                        //  ограничивает цикл длиною массива
    {
        if (outArrey[i] > max)                         //  ищет максимальное значение массива
        {
            max=outArrey[i];                           //  присваивает максимальное значение элементу массива  
        }    
        if (outArrey[i] < min)                         //  ищет минимальное значение массива
        {
            min=outArrey[i];                           //  присваивает минимальное значение массиву
        }
        i++;
    }
    return difference = (max-min);                     //  вычисляет разницу между минимальным и максимальным значением массива
}

int[] bufferArray = FillingArrey();                      // заполняет массив
PrintIntArray(bufferArray);                              // печатает массив        
Console.Write("разница между max и min значением массива=  " + CalculateTask(bufferArray));  // Запускает метод CalculateTask, закладывая переменную difference в bufferArray
