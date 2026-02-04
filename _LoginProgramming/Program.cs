namespace _LoginProgramming
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Account information

            string userName = "ProgrammingGirl_";
            var password = "userSun07*";

            const int maxAttempts = 3; // Maximum login attempts
            int attemptsLeft = maxAttempts; // Remaining attempts

            Console.WriteLine($"\nYou have {maxAttempts} rights for each failed attempt.\n");


            //Login attempts

            
            while (attemptsLeft > 0)
            {
                Console.Write("Enter your username: ");
                string name = Console.ReadLine() ?? string.Empty;
                Console.Write("\nEnter your password: ");
                var passw = Console.ReadLine() ?? string.Empty; 
                
                if (name == userName && passw == password)
                {
                    Console.WriteLine("\nSigning in... Thise proccess may take a few seconds.");
                    Console.WriteLine("Login successful.");
                    return; // Exit the program
                }
                attemptsLeft--;
                
                if (attemptsLeft > 0)
                {
                    Console.WriteLine("Username or password is incorrect. Please try again...");
                    Console.WriteLine($"Your remaning right {attemptsLeft}\n"); // Display remaining attempts
                }
                else
                {
                    Console.WriteLine("\nYou don't have any right. Login unsuccessful!");
                    return; // Exit the program
                }


            }

            Console.ReadKey();
     
            

        }
    }
}
