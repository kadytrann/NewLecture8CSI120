namespace NewLecture8CSI120
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kady Tran - 5/9/2024");

           /*
             Ask the user for an array size
             This will create 3 arrays
             One to hold all the numbers
            One to hold even numbers
            One to hold odd numbers
            We want to display the average each of the 3 arrays
             */

            // Ask the user for an array size

            // 1. Prompt the user for a whole number
            // 2. Try to parse the number
            // if it fails, we will prompt again
            // If the number is valid, we create 3 arrays



            string userValue;
            int size = 0;

            do
            {
                Console.Write("Please enter a whole number: ");
                userValue = Console.ReadLine();

                // IF the value is NOT  valid number, repeat
            } while (!int.TryParse(userValue, out size)); // What's happening here: If this is a proper value, save the value to size

            // We want this to keep looping until it's false

            // -------

            // This will create 3 arrays

            // int arrays, holding whole numbers 
            //Square brackets tells the computer we are creating an array
            int[] randomNumbers, evenNumbers, oddNumbers; // instead of putting a ; after, we can do commas, to create more than one array at the same time

            // Initialize our 3 arrays
            randomNumbers = new int[size];
            evenNumbers = new int[size];
            oddNumbers = new int[size];

            // -----------------

            // Random Object

            // Random objectName = new Random();
            Random rand = new Random();

            for (int i = 0; i < randomNumbers.Length; i++)
            {
                // First number is the min value
                // Second number is the max value. non inclusive
                // Non inclusive means does not include the argument value 
                // If you wanted to include the number 10, you should pass in 11
                

                int number = rand.Next(1, 10); // Next is a method to generate a number

                // Assign a random number to the current index
                // To do this, we call our array, and assign the number variable 
                randomNumbers[i] = number;
            } // End of for loop


            // To confirm this array prints out random numbers
            /* for (int i = 0; i < randomNumbers.Length; i++)
             {
                 Console.WriteLine(randomNumbers[i]);
             } */

            // At this point, you should have an array of random numbers

            // ---------------

            // Declare 2 variables, ints, that keep track of the current index
            // For our even and odd arrays

            // Sort the arrays into even and odd
            int evenIndex = 0;
            int oddIndex = 0;


            for (int i = 0; i < randomNumbers.Length; i++)
            {
                int currentNumber = randomNumbers[i];

                // userValue % 2 == 0
                // If the user Value / 2 does not have a remainder, it is even
                // Else it is odd


                if (currentNumber % 2 == 0)
                {
                    // If the number is even, assign the value to the even array
                    evenNumbers[evenIndex] = currentNumber;

                    // Increment our even index variable 
                    evenIndex++; // This adds 1 to the current valur
                }
                else
                {   // If the number is odd, assign the value to the odd array
                    oddNumbers[oddIndex] = currentNumber;
                    
                    oddIndex++;

                }
            }


            // -----------------

            // Display is properly set up
            // We do not need to change it

            // Display ALL numbers
            Console.Write("Display ALL numbers: ");
            for (int i = 0; i < randomNumbers.Length; i++)
            {
                Console.Write($"{randomNumbers[i]} ");
            }


            // This for loop will display all the even numbers
            // From the even numbers array
            Console.Write("\nEven Numbers: ");
                for (int i = 0; i < evenNumbers.Length; i++)
                {
                    Console.Write($"{evenNumbers[i]} ");
                }

                // This for loop will display all the odd numbers
                // From the odd numbers array
                Console.Write("\nOdd Numbers: "); // \n tells the computer to go to the next line
                for (int i = 0; i < oddNumbers.Length; i++)
                {
                    Console.Write($"{oddNumbers[i]} ");
                }

            // ----------------

            // We want to display the average each of the 3 arrays

            // How do we get the average of a set of numbers?
            // Sum all the values, and divide by the number of the elements

            // Placing the value outside. If you put the value inside, it will just replace the value over and over again


            double sumEven = 0;

            for (int i = 0; i < evenNumbers.Length; i++)
            {
                // Gets the current value
                int currentNumber = evenNumbers[i];

                // Adding the current number to our sumEven variable
                sumEven += currentNumber;
            }

            // RandomNumbers array had 10 numbers, then we could just divide by length
            // But our even arrays are the same size, but have a smaller number of even numbers
            // 2 4 4 2 / 10 -- Don't divide by .Length
            // Divide by the number of even or odd elements

            Console.WriteLine(); // An empty console writeline creates a new line
            Console.WriteLine($"Sum of Even Numbers: {sumEven}");

            // What is casting?
            // It is telling the computer what TYPE a value is
            // You do this by putting (type)value in front of your value
            double averageEven = sumEven / (double) evenIndex; // Make sure you cast 1 as a double, you can choose either one.
            Console.WriteLine($"Average of Even Numbers: {averageEven}");

            // Declared a variable to hold our odd Sum
            // Loop through the array and add our values to odd sum
            // Divided the oddsum by the oddIndex

            double oddSum = 0;

            for (int i = 0; i < oddNumbers.Length; i++)
            {
                int currentValue = oddNumbers[i];
                oddSum += currentValue;

            }

            Console.WriteLine($"Sum of Odd Numbers: {oddSum}");
            double averageOdd = oddSum / (double)oddIndex;
            Console.WriteLine($"Average of Odd Numbers: {averageOdd}");

        } // End of main
    } // End of class
} // End of namespace
