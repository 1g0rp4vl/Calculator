using System;

class Program {
    static void Main() {
        while (true) {
            Console.WriteLine("Введите первое число (или 'q' для выхода):");
            string num_str1 = Console.ReadLine();
            if (num_str1 == "q") {
                break; 
            }
            if (!double.TryParse(num_str1, out double num1)) {
                Console.WriteLine("Неверный ввод. Пожалуйста, введите число.");
                continue; 
            }
            
            Console.WriteLine("Введите операцию (+, -, *, /):");
            string op = Console.ReadLine();

            Console.WriteLine("Введите второе число:");
            if (!double.TryParse(Console.ReadLine(), out double num2)) {
                Console.WriteLine("Неверный ввод. Пожалуйста, введите число.");
                continue;
            }

            if (op == "+") {
                Console.WriteLine($"Результат: {num1 + num2}");
            } else if (op == "-") {
                Console.WriteLine($"Результат: {num1 - num2}");
            } else if (op == "*") {
                Console.WriteLine($"Результат: {num1 * num2}");
            } else if (op == "/") {
                if (num2 == 0) {
                    Console.WriteLine("На ноль делить нельзя");
                } else {
                    Console.WriteLine($"Результат: {num1 / num2}");
                }
            } else {
                Console.WriteLine("Неверная операция.");
            }
            Console.WriteLine("-----------------------------");
        }
    }
}