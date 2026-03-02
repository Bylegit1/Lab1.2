namespace Lab1._2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество чисел в последовательности: ");
            var count = int.Parse(Console.ReadLine());
            int[] massiv = new int[count];
    
            for(int i = 0; i < count; i++)
            {
                Console.WriteLine("Введите число в массив: ");
                massiv[i] = int.Parse(Console.ReadLine());
            }

            var counter = 0;
            var result = "";

            for (int i = 1; i < count; i++)
            {
                if (massiv[i] * massiv[i - 1] < 0)
                {
                    counter++;
                }
            }
            result ="Знак меняется ровно: " + counter + " раз(а)";
            Console.WriteLine(result);
            }
    }
}
