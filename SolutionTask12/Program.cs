string? inputLineOne = Console.ReadLine(); 
string? inputLineTwo = Console.ReadLine();

if(inputLineOne != null && inputLineTwo != null)
{
    int NumberOne =int.Parse(inputLineOne);
    int NumberTwo =int.Parse(inputLineTwo);
    int NumberTree = NumberTwo % NumberOne;

    if(NumberTree == 0)
    {   
            Console.WriteLine("yes");
    }    
    else
    {
       Console.WriteLine(NumberTree); 
    }

}