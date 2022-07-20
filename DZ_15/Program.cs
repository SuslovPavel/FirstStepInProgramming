Console.Clear();

Console.Write("Введите цифру соответствующую дню недели: ");   // принимаем значение с консоли
string? inputLineOne = Console.ReadLine(); 

int numberDay =int.Parse(inputLineOne);
if(numberDay == 7 || numberDay == 6 )
{
    Console.Write("Этот день является выходным");
}
else
{
   Console.Write("Этот день НЕ является выходным"); 
}