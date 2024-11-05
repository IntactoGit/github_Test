public class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("Введите первое число:");
            var firstNumber = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"Выберите команду: \n" +
                              $"1. Сложить числа \n" +
                              $"2. Вычесть числа \n" + 
                              $"3. Умножить числа \n"+
                              $"4. Поделить числа \n");

            var operation = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Введите второе число:");
            var secondNumber = Convert.ToDouble(Console.ReadLine());
            CalculateOperation(operation, firstNumber, secondNumber);
            
        }
    }
    private static void CalculateOperation(string operation, double firstNumber, double secondNumber)
    {
        double result;
        switch (operation)
        {
            case "+":
                result = firstNumber + secondNumber;
                Console.WriteLine("Результат: " + result);
                break;
            case "-":
                result = firstNumber - secondNumber;
                Console.WriteLine("Результат: " + result);
                break;
            case "*":
                result = firstNumber * secondNumber;
                Console.WriteLine("Результат: " + result);
                break;
            case "/":
                result = firstNumber / secondNumber;
                Console.WriteLine("Результат: " + result);
                break;
            default:
                Console.WriteLine("Выбрана неверная операция.");
                break;
            }
        }
    }
}