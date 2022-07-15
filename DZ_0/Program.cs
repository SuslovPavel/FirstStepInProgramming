string? inputLineOne = Console.ReadLine();
string? inputLineTwo = Console.ReadLine();

if(inputLineOne != null && inputLineTwo != null)
{
    int inputNumberOne =int.Parse(inputLineOne);
    int inputNumberTwo =int.Parse(inputLineTwo);

    if(inputNumberTwo > inputNumberOne)
    {   
        Console.WriteLine (inputLineTwo, ">" ,inputLineOne);
    }    
    else
    {
       Console.WriteLine (inputLineOne, ">" ,inputLineTwo); 
    }
}
// Андрей подскажите как исправить код чтобы при вводе 5,7 ответ в консоле выводился в виде "7 > 5", а не просто 7 как сейчас ????????