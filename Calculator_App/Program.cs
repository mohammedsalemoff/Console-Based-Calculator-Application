namespace Calculator_App
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // welcome the user in the application
            WelcomeApp("Console-Based Calculator");
            // declaring the variable holds the user choice to select the app to run
            byte nUserChoice = 0;
            while(true)
            {
                Separator();
                Console.WriteLine("\t\t\t\tCALCULATOR");
                Separator();
                Console.WriteLine(@"1. Addition
2. Subtraction
3. Multiplication
4. Division
5. Modulus
6. Power
7. Average
8. Maximum
9. Minimum
10. Exit");
                Separator();
                // ask the user to enter the choice then validate it
            ReadChoice: Console.Write("Enter your choice: ");
                if(!IsNumber(out nUserChoice))
                {
                    Console.WriteLine("Error: Please, enter a valid number");
                    goto ReadChoice;
                }
                if(!IsValidNumber(nUserChoice))
                {
                    Console.WriteLine(@"Invalid choice
Please, select a number from 1 to 10");
                    goto ReadChoice;
                }
                // select the program to run it
                SelectApp(nUserChoice);
                if (nUserChoice == 10)
                    return;
            }
        }

        #region GeneralMethods
        // 1- this method to welcome the user in the application
        static void WelcomeApp(string appName)
        {
            Console.WriteLine("*********************************************************************************");
            Console.WriteLine($@"Hi Sir, Welcome to {appName} Application
We hope you have a nice experience");
            Console.WriteLine("*********************************************************************************");
        }
        // 2- this method to print a separator in the beautiful form
        static void Separator()
        {
            Console.WriteLine("=================================================================================");
        }
        // 3- this method to read a byte number from the user
        static bool IsNumber(out byte number)
        {
            if (!byte.TryParse(Console.ReadLine(), out number))
                return false;
            return true;
        }
        // 4- this method to read an integer number from the user
        static bool IsNumber(out int number)
        {
            if (!int.TryParse(Console.ReadLine(), out number))
                return false;
            return true;
        }
        // 5- this method to read number of integer values from the user
        static void ReadValues(int[] values)
        {
            for (int i = 0; i < values.Length; i++)
            {
            ReadItem: Console.Write($"Enter item no. {i + 1}: ");
                if (!IsNumber(out values[i]))
                {
                    Console.WriteLine("Error: enter a valid number");
                    goto ReadItem;
                }
            }
        }
        #endregion

        #region AppMethods
        // 1- this method to check the the number given by the user is correct to select a program to run or not
        static bool IsValidNumber(byte number)
        {
            if (number <= 0 || number > 10)
                return false;
            return true;
        }
        // 2- this method to apply addition for two integer number given by the user
        static void Addition()
        {
            Console.Clear();
            int firstValue = 0, secondValue = 0;
        ReadFirst: Console.Write("Enter first number: ");
            if (!IsNumber(out firstValue))
            {
                Console.WriteLine("Error: Please, enter a valid number");
                goto ReadFirst;
            }
        ReadSecond: Console.Write("Enter second number: ");
            if (!IsNumber(out secondValue))
            {
                Console.WriteLine("Error: Please, enter a valid number");
                goto ReadSecond;
            }
            Console.WriteLine($"Sum is: {firstValue + secondValue}");
        }
        // 3- this method to apply subtraction for two integer number given by the user
        static void Subtraction()
        {
            Console.Clear();
            int firstValue = 0, secondValue = 0;
        ReadFirst: Console.Write("Enter first number: ");
            if (!IsNumber(out firstValue))
            {
                Console.WriteLine("Error: Please, enter a valid number");
                goto ReadFirst;
            }
        ReadSecond: Console.Write("Enter second number: ");
            if (!IsNumber(out secondValue))
            {
                Console.WriteLine("Error: Please, enter a valid number");
                goto ReadSecond;
            }
            Console.WriteLine($"Subtraction is: {firstValue - secondValue}");
        }
        // 4- this method to apply multiplication for two integer number given by the user
        static void Multiplication()
        {
            Console.Clear();
            int firstValue = 0, secondValue = 0;
        ReadFirst: Console.Write("Enter first number: ");
            if (!IsNumber(out firstValue))
            {
                Console.WriteLine("Error: Please, enter a valid number");
                goto ReadFirst;
            }
        ReadSecond: Console.Write("Enter second number: ");
            if (!IsNumber(out secondValue))
            {
                Console.WriteLine("Error: Please, enter a valid number");
                goto ReadSecond;
            }
            Console.WriteLine($"Multiplication is: {firstValue * secondValue}");
        }
        // 5- this method to apply division for two integer number given by the user
        static void Division()
        {
            Console.Clear();
            int firstValue = 0, secondValue = 0;
        ReadFirst: Console.Write("Enter first number: ");
            if (!IsNumber(out firstValue))
            {
                Console.WriteLine("Error: Please, enter a valid number");
                goto ReadFirst;
            }
        ReadSecond: Console.Write("Enter second number: ");
            if (!IsNumber(out secondValue))
            {
                Console.WriteLine("Error: Please, enter a valid number");
                goto ReadSecond;
            }
            if (secondValue == 0)
            {
                Console.WriteLine("Error: Cannot be divide by zero");
                goto ReadSecond;
            }
            Console.WriteLine($"Division is: {firstValue / secondValue}");
        }
        // 6- this method to apply modulus for two integer number given by the user
        static void Modulus()
        {
            Console.Clear();
            int firstValue = 0, secondValue = 0;
        ReadFirst: Console.Write("Enter first number: ");
            if (!IsNumber(out firstValue))
            {
                Console.WriteLine("Error: Please, enter a valid number");
                goto ReadFirst;
            }
        ReadSecond: Console.Write("Enter second number: ");
            if (!IsNumber(out secondValue))
            {
                Console.WriteLine("Error: Please, enter a valid number");
                goto ReadSecond;
            }
            if (secondValue == 0)
            {
                Console.WriteLine("Error: Second number cannot be zero");
                goto ReadSecond;
            }
            Console.WriteLine($"Remainder is: {firstValue % secondValue}");
        }
        // 7- this method to apply the power function for two integer number given by the user [base and exponent] 
        static void PowerApp()
        {
            Console.Clear();
            int baseValue = 0, exponent = 0;
        ReadBase: Console.Write("Enter the base value: ");
            if (!IsNumber(out baseValue))
            {
                Console.WriteLine("Please, enter a valid number");
                goto ReadBase;
            }
        ReadExponent: Console.Write("Enter the exponent value: ");
            if (!IsNumber(out exponent))
            {
                Console.WriteLine("Please, enter a valid number");
                goto ReadExponent;
            }
            if (exponent == 0 || exponent > 0)
                Console.WriteLine($"Result is: {Power(baseValue, exponent)}");
            else
                Console.WriteLine($"Result is: {1 / (Power(baseValue, -exponent))}");
        }
        // 8- this method to calculate the power for base and exponent
        static double Power(int baseValue, int exponent)
        {
            if (exponent == 0)
                return 1;
            long result = 1;
            for (int i = 0; i < exponent; i++)
                result *= baseValue;
            return result;
        }
        // 9- this method to apply Average app for number of values given by the user 
        static void AverageApp()
        {
            Console.Clear();
            // ask the user to enter how many numbers you want to enter
            int size = 0;
        ReadSize: Console.Write("Please, enter no. of values: ");
            if (!IsNumber(out size))
            {
                Console.WriteLine("Error: Enter a valid number");
                goto ReadSize;
            }
            int[] values = new int[size];
            // Read the values from the user
            ReadValues(values);
            // Calculate the average
            Console.WriteLine($"Average is: {Average(values)}");
        }
        // 10- this method to calculate the average of numbers
        static double Average(int[] values)
        {
            double sum = 0;
            foreach (int currentItem in values)
                sum += currentItem;
            return sum / values.Length;
        }
        // 11- this method to apply max app for number of values given by the user 
        static void MaxApp()
        {
            Console.Clear();
            // ask the user to enter how many numbers you want to enter
            int size = 0;
        ReadSize: Console.Write("Please, enter no. of values: ");
            if (!IsNumber(out size))
            {
                Console.WriteLine("Error: Enter a valid number");
                goto ReadSize;
            }
            int[] values = new int[size];
            // Read the values from the user
            ReadValues(values);
            // Calculate the maximum and print it 
            Console.WriteLine($"The maximum number is: {Max(values)}");

        }
        // 12- this method calcualtes the max number in set of numbers
        static int Max(int[] values)
        {
            int max = values[0];
            for (int i = 1; i < values.Length; i++)
            {
                if (values[i] > max)
                    max = values[i];
            }
            return max;
        }
        // 13- this method to apply min app for number of values given by the user 
        static void MinApp()
        {
            Console.Clear();
            // ask the user to enter how many numbers you want to enter
            int size = 0;
        ReadSize: Console.Write("Please, enter no. of values: ");
            if (!IsNumber(out size))
            {
                Console.WriteLine("Error: Enter a valid number");
                goto ReadSize;
            }
            int[] values = new int[size];
            // Read the values from the user
            ReadValues(values);
            // Calculate the maximum and print it 
            Console.WriteLine($"The minimum number is: {Min(values)}");
        }
        // 14- this method calcualtes the min number in set of numbers
        static int Min(int[] values)
        {
            int min = values[0];
            for (int i = 1; i < values.Length; i++)
            {
                if (values[i] < min)
                    min = values[i];
            }
            return min;
        }
        // 15- selcect the application to run it
        static void SelectApp(int nUserChoice)
        {
            switch (nUserChoice)
            {
                case 1:
                    Addition();
                    break;
                case 2:
                    Subtraction();
                    break;
                case 3:
                    Multiplication();
                    break;
                case 4:
                    Division();
                    break;
                case 5:
                    Modulus();
                    break;
                case 6:
                    PowerApp();
                    break;
                case 7:
                    AverageApp();
                    break;
                case 8:
                    MaxApp();
                    break;
                case 9:
                    MinApp();
                    break;
                case 10:
                    Console.WriteLine(@"Thank you for using the calculator!
See you later");
                    break;
            }
        }
        #endregion

    }

}
