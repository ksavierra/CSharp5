//Задайте массив заполненный случайными положительными трёхзначными числами. Напишите программу, которая покажет количество чётных чисел в массиве.


static void Main(string[] args)
        {
            int[] array = new int[4];
            Random RandomArray = new Random();
 
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = RandomArray.Next(100, 1000);
                Console.Write("{0} ", array[i]);
            }
                int count = 0;
            for (int i = 0; i < array.Length; i++)
            {
            if (array[i]%2 == 0)
            {
                count += 1;
            }
            
            }
            Console.Write("-> {0}", count);
         }
Main(args);
       