// Метод принимает значение от 1-4 и выдает допустимый диапазон


void printAnswer(int number)
{
    if(number==1) Console.WriteLine("Допустимо: x>0;y>0");  // проверяет значение и выводит результат на консоль

    if(number==2) Console.WriteLine("Допустимо: x<0;y>0");
    
    if(number==3) Console.WriteLine("Допустимо: x<0;y<0");

    if(number==4) Console.WriteLine("Допустимо: x>0;y<0");

}
string? inputLine = Console.ReadLine();            // считывает значения с консоли

if(inputLine != null)                              // проверка условия
{
    int inputNumber = int.Parse(inputLine);       // распознаёт значение и переводит его в строчку  
    
    printAnswer(inputNumber);
   
}