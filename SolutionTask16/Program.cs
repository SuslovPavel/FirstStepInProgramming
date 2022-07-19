Console.Clear();


Console.WriteLine("Введите первое число");
string? inputLineOne = Console.ReadLine(); 
Console.WriteLine("Введите второе число");
string? inputLineTwo = Console.ReadLine();


if(inputLineOne != null && inputLineTwo != null)
{
    int NumberOne =int.Parse(inputLineOne);
    int NumberTwo =int.Parse(inputLineTwo);
    int NumberTree = NumberTwo / NumberOne;
    int NumberFour = NumberOne / NumberTwo;

    if((NumberTree == NumberOne) || (NumberFour == NumberTwo))
    {   
        Console.WriteLine("yes");
    }    
    else
    {
       Console.WriteLine("No"); 
    }

}