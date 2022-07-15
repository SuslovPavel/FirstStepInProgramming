string? inputLine = Console.ReadLine(); 

if(inputLine != null)
{
    int inputNumber = int.Parse(inputLine);

    if(inputNumber%2 == 0)
    {
        Console.WriteLine("Yes");
    }
    else
    {
       Console.WriteLine("No");
    }   
    
}
