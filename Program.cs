internal class Program
{
    private static void Main(string[] args)
    {
        // Задача 64: Задайте значения M и N. Напишите рекурсивный метод, 
        // который выведет все натуральные числа кратные 3-ём в промежутке от M до N.
        // M = 1; N = 9. -> "3, 6, 9"; M = 13; N = 20. -> "15, 18".
        void Task64()
        {
            Console.WriteLine("Программа задаёт значения M и N и выводит все натуральные числа кратные 3-ём в промежутке от M до N.");
            Random rand = new Random();
            int m = rand.Next(0, 15);
            int n = rand.Next(15, 100);
            
            Console.Write($"Числа кратные 3-ём в промежутке от {m} до {n} -> ");
            RecTask64(m, n);

            void RecTask64(int firstNumber, int secondNumber)
            {
                if (firstNumber > secondNumber) return;
                if (firstNumber % 3 == 0)
                {
                    Console.Write(firstNumber + " ");
                    firstNumber++;
                    RecTask64(firstNumber, secondNumber);
                }
                else 
                {
                    firstNumber++;
                    RecTask64(firstNumber, secondNumber);
                }
            }
            Console.WriteLine("\n");
        }

        // Задача 66: Задайте значения M и N. Напишите рекурсивный метод, 
        // который найдёт сумму натуральных элементов в промежутке от M до N.
        // M = 1; N = 15 -> 120; M = 4; N = 8. -> 30.
        void Task66()
        {
            Console.WriteLine("Программа задаёт значения M и N и находит сумму натуральных элементов в промежутке от M до N.");
            Random rand = new Random();
            int m = rand.Next(0, 15);
            int n = rand.Next(15, 50);
            
            Console.Write($"Сумма натуральных чисел в промежутке от {m} до {n} равна ");
            RecTask66(m, n);
            
            void RecTask66(int firstNumber, int secondNumber, int sum = 0)
            {
                if (firstNumber > secondNumber) 
                {
                    Console.Write(sum);
                    return;
                }
                sum += firstNumber;
                firstNumber++;
                RecTask66(firstNumber, secondNumber, sum);
            }
            Console.WriteLine("\n");
        }

        // Задача 68: Напишите программу вычисления функции Аккермана с помощью рекурсии. Даны два неотрицательных числа m и n.
        // m = 2, n = 3 -> A(m,n) = 9; m = 3, n = 2 -> A(m,n) = 29.
        void Task68()
        {
            Console.WriteLine("Программа задаёт два неотрицательных числа и вычисляет функцию Аккермана.");
            Console.Write("Введите значение первого числа: ");
            int m = Convert.ToInt32(Console.ReadLine());
            Console.Write("Введите значение второго числа: ");
            int n = Convert.ToInt32(Console.ReadLine());
            if (m >= 0 && n >= 0) Console.WriteLine($"A({m},{n}) = {RecTask68(m, n)}");
            else Console.WriteLine($"Введённые значения не являются допустимыми.");
            
            int RecTask68(int firstNumber, int secondNumber)
            {
                if (firstNumber == 0)
                {
                    return secondNumber + 1;
                }
                else if (secondNumber == 0)
                {
                    return RecTask68(firstNumber - 1, 1);
                }
                else 
                {
                    return RecTask68(firstNumber - 1, RecTask68(firstNumber, secondNumber - 1));
                }
            }
        }
        Task64();
        Task66();
        Task68();
    }
}