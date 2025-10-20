
using System.Xml.Linq;

//Task1();
//Task2();
//Task3();
//Task4();
//Task5();
//Task6();
Task7();

void Task1()
{
    Console.Write("Enter a number 1-100: ");
    string? number = Console.ReadLine();
    int num = int.Parse(number);
    if (String.IsNullOrEmpty(number) || num <= 0 || num > 100)
    {
        Console.WriteLine("Error: invalid number. Exiting...");
    }
    else
    {
        if (num % 3 == 0 && num % 5 == 0)
        {
            Console.WriteLine("FizzBuzz");
        }
        else if (num % 3 == 0)
        {
            Console.WriteLine("Fizz");
        }
        else if (num % 5 == 0)
        {
            Console.WriteLine("Buzz");
        }
        else
        {
            Console.WriteLine(num);
        }
    }
}

void Task2()
{
    Console.Write("Enter a number: ");
    string? number = Console.ReadLine();
    int num = int.Parse(number);
    Console.Write("Enter %: ");
    string? pro = Console.ReadLine();
    int pr = int.Parse(pro);
    if (String.IsNullOrEmpty(number) || num <= 0 || String.IsNullOrEmpty(pro) || pr < 0)
    {
        Console.WriteLine("Error: invalid input. Exiting...");
    }
    else
    {
        int res = (num * pr) / 100;
        Console.WriteLine(pro + "% of " + number + " = " + res);
    }
}

void Task3()
{
    Console.Write("A: ");
    string? a = Console.ReadLine();

    Console.Write("B: ");
    string? b = Console.ReadLine();

    Console.Write("C: ");
    string? c = Console.ReadLine();

    Console.Write("D: ");
    string? d = Console.ReadLine();
    int res = int.Parse(a + b + c + d);
    Console.WriteLine("Result: " + res);
}


void Task4()
{
    Console.Write("Enter a 6 digit number: ");
    string? number = Console.ReadLine();
    int num = int.Parse(number);
    if (number == null || number.Length != 6)
    {
        Console.WriteLine("Error: not a 6-digit number.");
        return;
    }
    else
    {
        Console.Write("Enter the indexes: ");
        string? positions = Console.ReadLine();
        if (string.IsNullOrEmpty(positions))
        {
            Console.WriteLine("Error: no positions entered.");
            return;
        }
        string[] pos = positions.Split(' ');
        if (pos.Length != 2)
        {
            Console.WriteLine("Error: please enter two indexes separated by a space.");
            return;
        }

        int pos1 = int.Parse(pos[0]);
        int pos2 = int.Parse(pos[1]);

        if (pos1 < 1 || pos1 > 6 || pos2 < 1 || pos2 > 6)
        {
            Console.WriteLine("Error: indexes must be between 1 and 6.");
            return;
        }
        string ch1 = number.Substring(pos1-=1, 1);
        string ch2 = number.Substring(pos2-=1, 1);

        string result = "";

        for (int i = 0; i < number.Length; i++)
        {
            if (i == pos1)
                result += ch2;
            else if (i == pos2)
                result += ch1;
            else
                result += number[i];
        }

        Console.WriteLine("Result: " + result);
    }
}

void Task5()
{
    Console.Write("Enter a date (dd.mm.yyyy): ");
    string? input = Console.ReadLine();

    if (string.IsNullOrEmpty(input))
    {
        Console.WriteLine("Error: empty input.");
        return;
    }

    try
    {
        DateTime date = DateTime.ParseExact(input, "dd.MM.yyyy", null);

        string season = "";
        int month = date.Month;

        if (month == 12 || month == 1 || month == 2)
        {
            season = "Winter";
        }
        else if (month >= 3 && month <= 5)
        {
            season = "Spring";
        }
        else if (month >= 6 && month <= 8)
        {
            season = "Summer";
        }
        else
        {
            season = "Autumn";
        }

        string dayOfWeek = date.DayOfWeek.ToString();

        Console.WriteLine($"{season} {dayOfWeek}");
    }
    catch
    {
        Console.WriteLine("Error: invalid date format. Please use dd.MM.yyyy");
    }
}

void Task6()
{
    Console.Write("Enter temperature value: ");
    string? temp = Console.ReadLine();
    double t = double.Parse(temp);

    Console.Write("Choose conversion (1 - Fahrenheit to Celsius, 2 - Celsius to Fahrenheit): ");
    string? choice = Console.ReadLine();
    int c = int.Parse(choice);

    if (String.IsNullOrEmpty(temp) || String.IsNullOrEmpty(choice) || (c != 1 && c != 2))
    {
        Console.WriteLine("Error: invalid input. Exiting...");
    }
    else
    {
        if (c == 1)
        {
            double result = (t - 32) * 5 / 9;
            Console.WriteLine("Result: " + result.ToString("F1") + " °C");
        }
        else
        {
            double result = (t * 9 / 5) + 32;
            Console.WriteLine("Result: " + result.ToString("F1") + " °F");
        }
    }
}

void Task7()
{
    Console.Write("Enter first number: ");
    string? first = Console.ReadLine();
    int a = int.Parse(first);

    Console.Write("Enter second number: ");
    string? second = Console.ReadLine();
    int b = int.Parse(second);

    if (String.IsNullOrEmpty(first) || String.IsNullOrEmpty(second))
    {
        Console.WriteLine("Error: invalid input. Exiting...");
        return;
    }

    if (a > b)
    {
        int temp = a;
        a = b;
        b = temp;
    }

    Console.WriteLine("Even numbers in range " + a + " - " + b + ":");

    for (int i = a; i <= b; i++)
    {
        if (i % 2 == 0)
        {
            Console.Write(i + " ");
        }
    }

    Console.WriteLine();
}
