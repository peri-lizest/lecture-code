using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("간단한 계산기!");
        Console.WriteLine();

        while (true)
        {
            Console.WriteLine("어떤 계산을 수행하고 싶으신가요?");
            Console.WriteLine("1. 덧셈");
            Console.WriteLine("2. 뺄셈");
            Console.WriteLine("3. 곱셈");
            Console.WriteLine("4. 나눗셈");
            Console.WriteLine("e. 종료");
            Console.WriteLine();

            Console.Write("선택: ");
            string input = Console.ReadLine();

            switch (input)
            {
                case "1":
                    Addition();
                    break;
                case "2":
                    Subtraction();
                    break;
                case "3":
                    Multiplication();
                    break;
                case "4":
                    Division();
                    break;
                case "e":
                    Console.WriteLine("계산기를 종료합니다.");
                    return;
                default:
                    Console.WriteLine("올바른 선택을 입력하세요.");
                    break;
            }
            Console.WriteLine();
        }
    }

    static void Addition()
    {
        Console.Write("더할 첫 번째 숫자를 입력하세요: ");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("더할 두 번째 숫자를 입력하세요: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        double result = num1 + num2;
        Console.WriteLine($"덧셈 결과: {result}");
    }

    static void Subtraction()
    {
        Console.Write("빼질 첫 번째 숫자를 입력하세요: ");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("뺄 숫자를 입력하세요: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        double result = num1 - num2;
        Console.WriteLine($"뺄셈 결과: {result}");
    }

    static void Multiplication()
    {
        Console.Write("곱할 첫 번째 숫자를 입력하세요: ");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("곱할 두 번째 숫자를 입력하세요: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        double result = num1 * num2;
        Console.WriteLine($"곱셈 결과: {result}");
    }

    static void Division()
    {
        Console.Write("나눌 첫 번째 숫자를 입력하세요: ");
        double num1 = Convert.ToDouble(Console.ReadLine());

        Console.Write("나눌 숫자를 입력하세요: ");
        double num2 = Convert.ToDouble(Console.ReadLine());

        if (num2 == 0)
        {
            Console.WriteLine("0으로 나눌 수 없습니다.");
            return;
        }

        double result = num1 / num2;
        Console.WriteLine($"나눗셈 결과: {result}");
    }
}
