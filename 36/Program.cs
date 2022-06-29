Console.Write("Введите длину массива, L = ");
int L = Convert.ToInt32(Console.ReadLine());
int [] mass = new int [L];
    for (int i = 0; i < mass.Length; i++)
    {
        mass[i]  = new Random().Next(-100,101);
    }

searchNumber(mass);

void searchNumber (int [] mass)
{
    int sum = 0;
    for (int i = 0; i < mass.Length; i++)
    {
        if (i % 2 != 0)
        {
            sum = sum + mass[i];
        }
    }
        Console.Write("Массив - [");
        for (int i = 0; i < mass.Length - 1; i++){
            Console.Write($"{mass[i]}, ");
        }
        Console.Write($"{mass[mass.Length - 1]}");
        Console.Write("]");
        Console.WriteLine($"\nСумма элементов массива, которые стоят на нечетных позициях = {sum}");
}
