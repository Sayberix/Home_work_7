// Программа из введенного массива строк формирует массив строк, длина которого меньше либо равна 3 символам.

int n = Convert.ToInt32(Console.ReadLine());
if (n > 10)
{
    Console.WriteLine("К-во элементов массива должно быть меньше или равно 10! Программа завершает работу!")
    return;
}

string[] array = new string[n];
string[] resaultArray = new string[n];





void FillArray(string[] fillableArray)
{
    for (int i = 0; i < fillableArray.Length; i++)
    {
        Console.WriteLine("Введите значение в виде строки " + i + " элемента массива:");
        fillableArray[i] = Console.ReadLine();
    }
}

void ArrayCheck(string[] filledArray, string[] resaultArray)
{
    for (int i = 0; i < filledArray.Length; i++)
    {
        if (filledArray[i].Length > 3)
            Array.Clear(resaultArray, i, 1);
        else
            resaultArray[i] = filledArray[i];
    }
}

void ShowArray(string[] displayedArray)
{
    Console.WriteLine($"[{String.Join(";",displayedArray)}]");
}
