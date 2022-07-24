// Задайте массив вещественных чисел. Найдите разницу между максимальным и минимальным элементами массива.

static void Main(string[] args)
{
    Console.WriteLine("Введите количество элементов массива: ");

    int l = Convert.ToInt32(Console.ReadLine());
    int[] array = new int[l];
    float sum = 0;
 
    Random random = new Random();
    for (int i = 0; i < l; i++)
        {
            array[i] = random.Next(-1000, 1000);
            Console.Write(array[i] + " ");
        }

    int max = array[0]; 
        for (int i = 1; i < l; ++i)

        if (array[i] > max) 
        {        
            max = array[i];
        }
    int min = array[0]; 

        for (int i = 1; i < l; ++i)

        if (array[i] < min) 
        {
            min = array[i];
        }

    int difference = (max - min);
    int d = difference;

    Console.Write("-> Разница между max и min элементами =  " + d);
}        

Main(args);