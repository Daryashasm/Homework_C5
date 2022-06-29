Console.Write("Введите длину массива, L = ");
int L = Convert.ToInt32(Console.ReadLine());
double [] mass = new double [L];
    for (int i = 0; i < mass.Length; i++)
    {
        mass[i]  = Math.Round((new Random().NextDouble())*10, 2);
    }
        Console.Write("Массив - [");
        for (int i = 0; i < mass.Length - 1; i++){
            Console.Write($"{mass[i]}, ");
        }
        Console.Write($"{mass[mass.Length - 1]}");
        Console.Write("]");
double min = mass[0];
double max = mass[0];
    for (int i = 0; i < mass.Length; i++)
    {
        if (mass[i] > max)
        {
            max = mass [i];
        }
        if (mass[i] < min)
        {
            min = mass[i];
        }
    }
Console.Write($"\n{max} - максимальный элемент массива");
Console.Write($"\n{min} - минимальный элемент массив");
Console.WriteLine($"\nРазница между элементами = {Math.Round(max-min,2)}");
