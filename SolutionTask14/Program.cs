string? inputLineOne = Console.ReadLine(); 

if(inputLineOne !=null)
{
    int NumberOne =int.Parse(inputLineOne);
    int result1 = NumberOne % 7;
    int result2 = NumberOne % 23;

    if(result1 == 0 && result2 == 0)
    {   
        Console.WriteLine("Yes");
    }
    else
    {
        Console.WriteLine("No");
    }
}