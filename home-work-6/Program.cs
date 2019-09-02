using System;
namespace home_work_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Massiv massiv = new Massiv(3);
            for(int i = 0; i < massiv._size; i++)
            {
                massiv[i] = i + 1;
                Console.WriteLine(massiv[i]);
            }
            //for (int i = 0; i < massiv._size; i++)
            //{
                
            //}
            Console.ReadKey();
        }
    }
}
