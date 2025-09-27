namespace delegates
{
    internal class Program
    {
        public static Array FindEvenNumbers(int[] array)
        {
            return Array.FindAll(array, number => number % 2 == 0);
        }
        public static Array FindOddNumbers(int[] array)
        {
            return Array.FindAll(array, number => number % 2 != 0);
        }
        public static Array FindPrimeNumbers(int[] array)
        {
            return Array.FindAll(array, IsPrime);
        }
        public static Array FindFibonacciNumbers(int[] array)
        {
            return Array.FindAll(array, IsFibonacci);
        }
        public static bool IsPrime(int number)
        {
            if (number <= 1) return false;
            for (int i = 2; i <= Math.Sqrt(number); i++)
            {
                if (number % i == 0) return false;
            }
            return true;
        }
        public static bool IsFibonacci(int number)
        {
            if (number < 0) return false;
            int a = 0, b = 1;
            while (b < number)
            {
                int temp = b;
                b += a;
                a = temp;
            }
            return b == number || number == 0;
        }
        public delegate Array filterDelegate(int[] array);
        static void Main(string[] args)
        {
            //Створіть набір методів для роботи з масивами:
            //Метод для отримання всіх парних чисел у масиві;
            //Метод для отримання всіх непарних чисел у масиві;
            //Метод для отримання всіх простих чисел у масиві;
            //Метод для отримання всіх чисел Фібоначчі в масиві.
            //Використовуйте механізми делегатів.

            int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
            filterDelegate filter;
            filter = FindEvenNumbers;
            Console.WriteLine("Even numbers: ");
            foreach(int number in filter(numbers))
            {
                Console.Write(number + " ");
            }
            filter = FindOddNumbers;
            Console.WriteLine("\nOdd numbers: ");
            foreach (int number in filter(numbers))
            {
                Console.Write(number + " ");
            }
            filter = FindPrimeNumbers;
            Console.WriteLine("\nPrime numbers: ");
            foreach (int number in filter(numbers))
            {
                Console.Write(number + " ");
            }
            filter = FindFibonacciNumbers;
            Console.WriteLine("\nFibonacci numbers: ");
            foreach (int number in filter(numbers))
            {
                Console.Write(number + " ");
            }
        }
    }
}
