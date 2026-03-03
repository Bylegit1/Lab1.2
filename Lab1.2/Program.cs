namespace Lab1._2
{
    public class SignChangeLogic
    {
        public static int CountSignChange(int[] massiv)
        {
            var counter = 0;

            if (massiv == null || massiv.Length < 2)
            {
                return 0;
            }

            for (int i = 1; i < massiv.Length; i++)
            {
                if (massiv[i] * massiv[i - 1] < 0)
                {
                    counter++;
                }
            }
            return counter;
        }
    }
    class Program
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

            var counter = SignChangeLogic.CountSignChange(massiv);
            var result = "";

            result ="Знак меняется ровно: " + counter + " раз(а)";
            Console.WriteLine(result);
            }
    }
}
