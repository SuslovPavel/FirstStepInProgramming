//  Задача №39 Напишите программу, которая перевернёт одномерный массив (последний элемент будет на первом месте, а первый - на последнем и т.д.)
//  Например:[1 2 3 4 5] -> [5 4 3 2 1] 
//           [6 7 3 6] -> [6 3 7 6]
//  Комментарий: эту задачу можно решить 2 способами: 1) менять числа местами в исходном массиве; 2) создать новый массив и в него записать перевёрнутый исходный массив по элементам.


int[] FillingArrey(int arrayLength)  //  Метод возвращает массив заполняя случайными числами (запись вскобках позволяет принимать длинну массива из вне)
{
    int[] outArray = new int[arrayLength];                   // создаём переменную, выделяем память под неё, длина массива принимается из вне
    int i = 0;                                               // индекс массива
    System.Random numberSintezator = new System.Random();    // создаём синтезатор случайных чисел, выделяем под него память
    while (i < arrayLength)                                           // Цикл заполняет массив
    {
        outArray[i] = numberSintezator.Next(-100,100);       // Запускает синтезатор в границах от -100 до 99
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

int[] ReversNewArray(int[] array)            //  Метод переворачивает массив
{
    int [] newArray = new int[array.Length];
    for(int i=0; i<array.Length; i++)                   // применяет вычисления по всей длине массива
    {
        newArray[array.Length-1-i]=array[i];            //  присваивает элементам массива новые индексы в соответствии с i
    }
    return newArray;
}

int[] ReversSwapArray(int[] array)            //  Метод переворачивает массив
{
    int buf;                                      // создаём переменную в которую на время кладём
    for(int i=0; i<array.Length/2; i++)                  // применяет вычисления по всей длине массива
    {
        buf = array[i];                                //  в буфер кладёт эл-т массива соответствующий i
        array[i] = array[array.Length - 1 -i];         //  присваивает первому элементу массива значение последнего итд по мере увеличения i
        array[array.Length - 1 - i] = buf;             //  кладёт последний элемент ассива в буфер итд по мере увеличения i
    }
    return array;
}


int[] testArray = FillingArrey(23);

PrintIntArray(testArray);
PrintIntArray(ReversNewArray(testArray));
PrintIntArray(ReversSwapArray(testArray));           // вызывает метод и сразу печатает его


