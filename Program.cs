int input1;
int input2;
int input3;
int input4;
int input5;
int input6;

try
{


    Console.WriteLine("Please in put your results for Module 1");
    input1 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Please in put your results for Module 2");
    input2 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Please in put your results for Module 3");
    input3 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Please in put your results for Module 4");
    input4 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Please in put your results for Module 5");
    input5 = Convert.ToInt32(Console.ReadLine());

    Console.WriteLine("Please in put your results for Module 6");
    input6 = Convert.ToInt32(Console.ReadLine());

    int average = (input1 + input2 + input3 + input4 + input5 + input6) / 6;

    switch (average)
    {
        case >= 70:
            Console.WriteLine("1st");
            break;

        case >= 60:
            Console.WriteLine("2;1");
            break;

        case >= 50:
            Console.WriteLine("2:2");
            break;

        case > 40:
            Console.WriteLine("3rd");
            break;

        case >= 40:
            Console.WriteLine("Pass");
            break;

        case < 39:
            Console.WriteLine("Fail");
            break;

    }
    }
catch
{
    Console.WriteLine("Wrong Input");
}

Console.ReadKey();