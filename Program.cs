int[] rainfallamt = new int[12];

rainfallamt[0] = 84;
rainfallamt[1] = 129;
rainfallamt[2] = 52;
rainfallamt[3] = 50;
rainfallamt[4] = 145;
rainfallamt[5] = 116;
rainfallamt[6] = 97;
rainfallamt[7] = 118;
rainfallamt[8] = 113;
rainfallamt[9] = 97;
rainfallamt[10] = 83;
rainfallamt[11] = 140;

int rainfallsum = rainfallamt.Sum() / 12;

Console.WriteLine("The average amount of rainfall is " + rainfallsum);

Console.ReadKey();

/*
int num1;
int num2;
string meth;
int sum;
char choice;

do
{
    try
    {
        Console.WriteLine("Please input your first number");
        num1 = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Please input your operator");
        meth = Convert.ToString(Console.ReadLine());

        Console.WriteLine("Please input your second number");
        num2 = Convert.ToInt32(Console.ReadLine());



        switch (meth)
        {
            case "+":
                Console.WriteLine("You have selected +");
                sum = num1 + num2;
                Console.WriteLine("The sum of your inputs is " + sum);
                break;

            case "-":
                Console.WriteLine("You have selected -");
                sum = num1 - num2;
                Console.WriteLine("The sum of your inputs is " + sum);
                break;

            case "*":
                Console.WriteLine("You have selected *");
                sum = num1 * num2;
                Console.WriteLine("The sum of your inputs is " + sum);
                break;

            case "/":
                Console.WriteLine("You have selected /");
                sum = num1 / num2;
                Console.WriteLine("The sum of your inputs is " + sum);
                break;

            case "%":
                Console.WriteLine("You have selected %");
                sum = num1 % num2;
                Console.WriteLine("The sum of your inputs is " + sum);
                break;
        }
    }
    catch
    {
        Console.WriteLine("Incorrect Input");
    }
    Console.WriteLine("Do you want to try again?");
    choice = Convert.ToChar(Console.ReadLine());
}
while (choice != 'N');
Console.ReadKey();

//Random = new Random();
//int number = rand.next(0, 100);
/*
int input1;
int input2;
int input3;
int input4;
int input5;
int input6;

char choice;
do
{


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
    Console.WriteLine("Do you want to try again?");
    choice = Convert.ToChar(Console.ReadLine());
}
while (choice != 'N');
Console.ReadKey();
*/