namespace Prog_120_S23_L15_ForLoops
{
    internal class Program
    {
        static void Main(string[] args)
        {


            // You use a while loop if you do not know the end condition
            // Asks the user to reenter their user name and password

            string userName = "Will";
            string password = "Cram";

            Console.Write("User Name: ");
            string userInputName = Console.ReadLine();

            Console.Write("Password: ");
            string userPassword = Console.ReadLine();

            // Did the user enter the wrong name OR did the user enter the wrong password

            // Name and password and they are BOTH correct
            bool userNameIsIncorrect = userInputName != userName;


            // A loop will always run while true. <----
            // It's all in how we phrase the question
            while (userInputName != userName || userPassword != password)
            {

            }


        } // main

        public static void SecondForLoopExample()
        {
            // First part of for loop
            // int i = 0;

            // Step 2: Jumps to our condition

            // Step 3 : Runs Code
            // Step 4 : Increments
            // Repeat at step 2

            // You use a for loop if you know the end condition
            // 0 to 100

            for (int i = 47; i < 91; i++)
            {
                char letter = (char)i;
                Console.WriteLine(i + " : " + letter);
            }

            ////Arrays
            //int[] numbers = new int[19];
            //numbers.Length to get number of elements

            // What is the shortcut for a for loop
            // for + tab + tab
            //for (int i = 0; i < length; i++)
            //{

            //}

        }

        public static void LastExample()
        {
            //do
            //{
            //    Console.WriteLine("Enter your username: ");
            //    userName = Console.ReadLine();

            //    Console.WriteLine("Enter your password: ");
            //    password = Console.ReadLine();

            //    if (userName == "Ben" && password == "ben1")

            //    {
            //        Console.WriteLine("Welcome, " + userName);
            //        break;
            //    }
            //    else
            //    {
            //        Console.WriteLine("Invalid username or password");
            //    }

            //    attempts++;

            //    if (attempts >= 3)
            //    {
            //        Console.WriteLine("Max number of attempts reached. Exiting...");
            //        return;
            //    }

            //} while (true);

            //Console.WriteLine("You have successfully logged in!");
            //Console.WriteLine($"Max number of attempts: {attempts}\n");



        }

        // Inital Example
        public static void ForLoopBegin()
        {

            // For Loop



            //for (
            //    int i = 0; // Initializing a value called i with a number of 0
            //    i < 10; // Condition - Runs while true
            //    i++) // Increment - Changes the i value
            //{
            //    Console.WriteLine(i);
            //} // End of for loop

            // -------------------------------------------

            // While loop that prints 0 to 9


            //int i = 0; // Delcared a value that will change

            //while(i < 10) // Condition that our loop will run
            //{
            //    Console.WriteLine(i);
            //    i++; // Changed the value
            //}

        }

        // For loop
        // Purpose
        // Syntax
        // Useage with arrays
        // Nested Loops


    } // class

} // namespace