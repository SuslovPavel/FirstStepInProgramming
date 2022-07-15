string? inputLineOne = Console.ReadLine();
string? inputLineTwo = Console.ReadLine();
string? inputLineThree = Console.ReadLine();

if(inputLineOne != null && inputLineTwo != null && inputLineThree != null)
{
    int inputNumberOne =int.Parse(inputLineOne);
    int inputNumberTwo =int.Parse(inputLineTwo);
    int inputNumberThree =int.Parse(inputLineThree);

    if(inputNumberOne > inputNumberTwo)
    {
      if(inputNumberTwo > inputNumberThree)
      {   
        Console.WriteLine (inputLineOne);
      }
      if(inputNumberOne > inputNumberThree)
      {
       Console.WriteLine (inputLineOne); 
      }
      if(inputNumberOne < inputNumberThree)
      {
        Console.WriteLine (inputLineThree);
      }         
    }
    if(inputNumberOne < inputNumberTwo)
    {
      if(inputNumberTwo < inputNumberThree)
      {   
        Console.WriteLine (inputLineThree);
      }
      if(inputNumberTwo > inputNumberThree)
      {
        Console.WriteLine (inputLineTwo);

      }          
    }

}   
      
