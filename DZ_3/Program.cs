﻿string? inputLine = Console.ReadLine(); 

if(inputLine != null)
{
    int inputNumber = int.Parse(inputLine);

    int startNumber = 1;

    string lineOutput = "0";

    while(startNumber <= inputNumber)
    {
        lineOutput = startNumber+1+", " +lineOutput+2;
        startNumber++;
    }
        
    

    Console.WriteLine(lineOutput);
}    
  // код нерабочий, незнаю как решить