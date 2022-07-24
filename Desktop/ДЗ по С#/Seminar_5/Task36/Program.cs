// Задайте одномерный массив, заполненный случайными числами. Найдите сумму элементов, стоящих на нечётных позициях/

static void Main(string[] args)
{
    Console.WriteLine("Введите количество элементов массива: ");

    int l = Convert.ToInt32(Console.ReadLine());
    int[] array = new int[l];
    float sum = 0;
 
    Random random = new Random();

    for (int i = 0; i < l; i++)
        {
            array[i] = random.Next(0, 1000);
            Console.Write(array[i] + " ");
        }

    for (int i = 0; i < l; i += 2) 
        {
            sum = sum + array[i];            
        }
 
            Console.Write("{0}" , "-> ");
            Console.Write(sum);
            Console.ReadKey();
} 

Main(args);




