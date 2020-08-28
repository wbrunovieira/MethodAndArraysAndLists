using System;

namespace MethodAndArraysAndLists
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Counter");
            Console.WriteLine("###############################");
            Counter();

            PauseConsole();

            Console.WriteLine("Counter by 3");
            Console.WriteLine("###############################");

            CounterTree();

            PauseConsole();

            Console.WriteLine("Check numbers if they are equal");
            Console.WriteLine("###############################");


            int userNum1 = GetUserNumber();
            int userNum2 = GetUserNumber();
            bool areEqual = EqualChecker(userNum1, userNum2);
            Console.WriteLine($"{userNum1} is equal to {userNum2}: {areEqual}");

            PauseConsole();

            Console.WriteLine("Check if the number is even or odd");
            Console.WriteLine("###############################");
            EvenOrOdd(userNum1);

            PauseConsole();

            Console.WriteLine("Check if the number is positive or negative");
            Console.WriteLine("###############################");

            userNum1 = GetUserNumber();


            PositivoOrNegative(userNum1);

            Console.WriteLine("Checker vote age");
            Console.WriteLine("###############################");


            Console.Write("Please tell me your age and we will tell you if you can vote!");
            int age;
            while(!int.TryParse(Console.ReadLine(), out age))
            {
                Console.WriteLine("Could not compute. Try again");
            }

            AgeChecker(age);

            Console.WriteLine("Ranger -10 to 10 from your number");
            Console.WriteLine("###############################");


            int userNumber = GetUserNumber();

            RangeChecker(userNumber);

            userNumber = GetUserNumber();

            int multiplyTo = GetUserNumber();

            Console.WriteLine("Multiplator Table");
            Console.WriteLine("###############################");

            MultiTable(userNumber, multiplyTo);

            int userNumberMult = GetUserNumber();

            int[] randoNumbers = Populator(userNumber);

            foreach(var number in randoNumbers)
            {
                Console.WriteLine(number);
            }

            int sumOfElements = SumArray(randoNumbers);

            Console.WriteLine($"The sum of intergers in the array is {sumOfElements}");

            PauseConsole();

            Console.WriteLine("Cuber");
            Console.WriteLine("###############################");

            userNumber = GetUserNumber();

            Cuber(userNumber);
        }

        
    private static void Cuber(int cubeTo)
        {
            double cubed = 0;

            for (int i = 1; i <= cubeTo; i++)
            {
                cubed = Math.Pow(i, 3);
                Console.WriteLine($"Number is {i} and the cube of {i} is: {cubed}");
            } 
        }


    private static int SumArray(int[] randonNumber)
    {
        int sum = 0;

        for (int i = 0; i < randonNumber.Length; i++)
        {
            sum += randonNumber[i];

        }

        return sum;
    }

        private static int[] Populator(int userNumber)
        {
            int[] randons = new int[userNumber];
            Random rng = new Random();

            for(int i = 0; i < randons.Length; i++)
            {
                randons[i] = rng.Next(501);
            }

            return randons;
        }

        private static void MultiTable(int userNumber, int multiplyTo)
        {
            int product = 0;

            for (int i = 1; i <= multiplyTo; i++)
            {
                product = userNumber * i;
                Console.WriteLine($"{userNumber} X {i} result {product}");
            }
        }

        private static void RangeChecker(int userNumber)
        {
            if(userNumber >= -10 && userNumber <= 10)
            {
                Console.WriteLine($"{userNumber} is in the range. ");
            }
            else
            {
                Console.WriteLine($"{userNumber} is not in the range.");
            }
        }

        private static void AgeChecker(int userAge)
        {
            if(userAge >= 18)
            {
                Console.WriteLine("You may vote !");
            }

            else
            {
                Console.WriteLine("You are not allowed to vote yet !");
            }
        }

        private static void PositivoOrNegative(int num1)
        {
           if(num1 > 0)
            {
                Console.WriteLine("The number is positive.");
            }

            else
            {
                Console.WriteLine("The number is negative.");
            }
        }

        private static void EvenOrOdd(int userName)
        {
            if(userName % 2 == 0)
            {
                Console.WriteLine($"{userName} is even !!!");
            }
            else if(userName % 2 != 0)
            {
                Console.WriteLine($"{userName} is odd!!");
            }
            else
            {
                Console.WriteLine("I have no clue what that is! Maybe is zero");
            }
        }

        private static int GetUserNumber()
        {
            Console.Write("Give me a number: ");
            int userNumber = int.Parse(Console.ReadLine());

            return userNumber;

           
        }

        private static bool EqualChecker(int num1, int num2)
        {
           return num1 == num2;
        }

        private static void CounterTree()
        {
            for (int i = 3; i <= 999; i += 3)
            {
                Console.WriteLine(i);
            }
        }


        private static void Counter()
        {
            int goal = -1000;

            for (int i = 1000; i >= goal; i--)
            {
                Console.WriteLine(i);
            } 
        }

        private static void PauseConsole()
        {
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
