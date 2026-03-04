namespace Lab1._2
{
    public class SignChangeLogic
    {
        public static int countSignChange(int[] numbers)
        {
            var counter = 0;

            if (numbers == null || numbers.Length < 2)
            {
                return 0;
            }

            for (int i = 1; i < numbers.Length; i++)
            {
                if (numbers[i] * numbers[i - 1] < 0)
                {
                    counter++;
                }
            }
            return counter;
        }

        public static string outputChangedSymbolCount(int[] numbers)
        {
            var counter = SignChangeLogic.countSignChange(numbers);
            var result = "Знак меняется ровно: " + counter + " раз(а)";
            return result;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество чисел в последовательности: ");
            var count = int.Parse(Console.ReadLine());
            int[] numbers = new int[count];
    
            for(int i = 0; i < count; i++)
            {
                Console.WriteLine("Введите число в массив: ");
                numbers[i] = int.Parse(Console.ReadLine());
            }

            var result = SignChangeLogic.outputChangedSymbolCount(numbers);

            Console.WriteLine(result);
            }
    }
}
