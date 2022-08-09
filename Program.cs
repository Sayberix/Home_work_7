// Программа из введенного массива строк формирует массив строк, длина которого меньше либо равна 3 символам.

int n = Convert.ToInt32(Console.ReadLine());
if (n > 10)
{
    Console.WriteLine("К-во элементов массива должно быть меньше или равно 10! Программа завершает работу!")
    return;
}

int [] array = new int [n];
int [] resaultArray = new int [n];


