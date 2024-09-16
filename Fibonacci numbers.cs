using System;

class Fibonacci {
    static void Main(string[] args) {
        Console.Write("Добрий день! Дана програма розраховує числа Фібоначчі. Введіть кількість чисел: ");
        int numbers = Convert.ToInt32(Console.ReadLine());

        if (numbers <= 0) {
            Console.WriteLine("Кількість чисел повинна бути більшою за 0.");
        } else {
            Console.WriteLine("Числа Фібоначчі:");
            for (int i = 0; i < numbers; i++) {
                Console.WriteLine($"{i + 1}: {FibonacciNumber(i)}");
            }
        }
    }

    static int FibonacciNumber(int n) {
        if (n < 0) {
            throw new ArgumentOutOfRangeException("n", "Індекс не може бути від'ємним.");
        }
        if (n == 0) return 0; 
        if (n == 1) return 1; 
        int a = 1;
        int b = 1;
        int c = 0;

        for (int i = 2; i <= n; i++) {
            c = a + b;
            a = b;
            b = c;
        }

        return c;
    }
}
