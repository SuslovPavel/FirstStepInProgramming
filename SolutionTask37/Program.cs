//  Найдите произведение пар чисел в одномерном массиве. Парой считаем первый и последний элемент, второй и предпоследний и т.д. Результат запишите в новом массиве.
// Например: [1 2 3 4 5] -> 5 8 3
//           [6 7 3 6] -> 36 21

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

int[] CalculateTask(int[] inputArray)  //  Метод перемножает крайние эл-ты массива
{
    int[] resultArray = new int[inputArray.Length/2];                                 // Cоздаём переменную в виде масива
    int i = 0;
    while(i<resultArray.Length)                                                        // применяет вычисления по всей длине массива
    {
        resultArray[i] = inputArray[i]*inputArray[inputArray.Length-1-i];              //  команда пермножает крайние эл-ты массива  
        i++;
    }
    return resultArray;
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

int[] bufferArray = FillingArrey();                      // заполняет массив
PrintIntArray(bufferArray);                              // печатает массив
int[] resultArray = CalculateTask(bufferArray);          // вызывает метод, заполняет новым массивом после вычисления
PrintIntArray(resultArray);                              // печатает новый массив