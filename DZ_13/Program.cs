Console.Clear();

Console.Write("Введите трёхзначное число: "); // принимаем значение с консоли
string? inputLineOne = Console.ReadLine()?? "";

char[] M = inputLineOne.ToCharArray();       // преобразуем значение в массив
if (M.Length < 3)                            // выставляем условие что длина массива не менее 3х элементов
{
    Console.Write("Третьей цифры нет");
}
else
{
    Console.Write("Вторая цифра числа: ");
    Console.WriteLine(M[2]);
}
