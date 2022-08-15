//  Задайте массив из 12 элементов, заполненный случайными числами из промежутка [-9, 9]. 
//  Найдите сумму отрицательных и положительных элементов массива.
//  Например, в массиве [3,9,-8,1,0,-7,2,-1,8,-3,-1,6] сумма положительных чисел равна 29, сумма отрицательных равна -20.

int positivSum = 0;  //  переменные для накопления результата
int negativSum = 0;

int[] FillingArrey() // Метод возвращает массив заполняя случайными числами от -9 до 9
{
    int[] outArrey = new int[12];  // создаём переменную, выделяем память под неё, задаём длину массива 12 элементов
    int i = 0;                      // индекс массива
    System.Random numberSintezator = new System.Random();  // создаём синтезатор случайных чисел, выделяем под него память
    while (i < 12)  // Цикл заполняет массив
    {
        outArrey[i] = numberSintezator.Next(-9, 10);  // Запускает синтезатор в промежутке от -9 до 10
        i++;
    }
    return outArrey;
}

void CalculateTask(int[] outArrey) // принимает массив котозаполненый в предыдущем методе "int [] FillingArrey()"
{
    int i = 0;
    while (i < 12)       // ограничивает цикл 12тью итерациями
    {
        if (outArrey[i] > 0)   // разделяет значения массива на положительные и отрицательные
        {
            positivSum++;     // сумирует положительные значения массива
        }
        else
        {
            negativSum++;     // // сумирует отрицательные значения массива
        }

    } 

}

void PrintResult()                // выводит результат на консоль
{
    Console.WriteLine(positivSum);
    Console.WriteLine(negativSum);
}

void VariantNaive()               
{
    int[] bufferArrey = FillingArrey();
    CalculateTask(bufferArrey);
    PrintResult();
}

VariantNaive();
