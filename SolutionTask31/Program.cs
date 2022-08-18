//  Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. 
//  Найдите сумму отрицательных и положительных элементов массива.
//  Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20.

int positivSum = 0;                                         //  переменные для накопления результата
int negativSum = 0;

int[] FillingArrey() // Метод возвращает массив заполняя случайными числами от -9 до 9
{
    int[] outArrey = new int[12];                           // создаём переменную, выделяем память под неё, задаём длину массива 12 элементов
    int i = 0;                                              // индекс массива
    System.Random numberSintezator = new System.Random();   // создаём синтезатор случайных чисел, выделяем под него память
    while (i < 12)                                          // Цикл заполняет массив
    {
        outArrey[i] = numberSintezator.Next(-9, 10);        // Запускает синтезатор в промежутке от -9 до 10
        i++;
    }
    return outArrey;
}

void CalculateTask(int[] outArrey) // принимает массив который заполнен в предыдущем методе "int [] FillingArrey()"
{
    int i = 0;
    while (i < 12)                                          // ограничивает цикл 12тью итерациями
    {
        if (outArrey[i] > 0)                                // разделяет значения массива на положительные и отрицательные
        {
            positivSum += outArrey[i];                        // сумирует положительные значения массива  / positivSum++  будет считать кол-во положительных чисел
        }
        else
        {
            negativSum += outArrey[i];                        // сумирует отрицательные значения массива  / negativSum++  будет считать кол-во отрицательных чисел
        }
        i++;

    }

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

void PrintResult()  // выводит результат на консоль
{
    Console.WriteLine(positivSum);
    Console.WriteLine(negativSum);
}

void VariantNaive()
{
    int[] bufferArray = FillingArrey();
    PrintIntArray(bufferArray);
    CalculateTask(bufferArray);
    PrintResult();
}

void VariantSimple()  //  Метод решения задачи 31 простой
{
    System.Random numberSintezator = new System.Random();  //  Создаем экземпляр класса рандомайзер
    int i = 0;                                      //Буфферные переменные
    int buf = 0;
    int positivSum = 0;
    int negativSum = 0;

    while (i < 12)                                 //  Цикл заполнения массива
    {
        buf = numberSintezator.Next(-9, 10);         //Получаем новое значение
        Console.Write(buf + ", ");
        if (buf > 0)                                //Накапливаем результат
        {
            positivSum += buf;                     //Элемент положительный
        }
        else
        {
            negativSum += buf;                     //Элемент отрицательный
        }
        i++;                                      //Увеличиваем инкремент
    }
    //Console.Write(buf);
    Console.WriteLine();
    Console.WriteLine(positivSum);                //Выводим сумму положительных значений
    Console.WriteLine(negativSum);                //Выводим сумму отрицательных значений
    }

    int t;
    t = Environment.TickCount;
    //Вариант 1
    VariantNaive();
    Console.WriteLine("Naive time: {0} ms", Environment.TickCount - t);

    t = Environment.TickCount;
    //Вариант 2
    VariantSimple();
    Console.WriteLine("Simple time: {0} ms", Environment.TickCount - t);
