
// Напишите программу, которая принимает на вход число и выдаёт сумму цифр в числе. //


Console.Write("Введите число: ");
string inputLineNumberA = Console.ReadLine() ?? "";
int numberA = int.Parse(inputLineNumberA);
int numberB = 0; 

// void MethodInt()
// {
//     while (numberA > 0)
//     {
//         numberB = numberB + numberA % 10;
//         numberA = numberA / 10;
//     }
//     Console.WriteLine(numberB);
// }
// MethodInt();

char[] M = inputLineNumberA.ToCharArray();
int i= M.Length;
while (M[i]<= i)
{
numberB = M[0]+M[i];
}
Console.WriteLine(numberB);