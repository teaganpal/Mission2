
// See https://aka.ms/new-console-template for more information

using Mission2;

internal class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Welcome to the dice throwing simulator!");
        Console.WriteLine("\nHow many dice rolls would you like to simulate?");
        // getting number of rolls from user
        int numOfRolls = Convert.ToInt32(Console.ReadLine());

        // establishing a Rolling class instance
        Rolling diceRoller = new Rolling();
        
        // getting diceSimulator results
        int[] rollsStats = diceRoller.DiceSimulator(numOfRolls);

        Console.WriteLine("\nDICE ROLLING SIMULATION RESULTS");
        Console.WriteLine("Each \"*\" represents 1% of the total number of rolls.");
        Console.WriteLine("Total number of rolls = " + numOfRolls + "\n");

        // creating histogram
        for (int i = 0; i < rollsStats.Length; i++)
        {
            int percentage = (rollsStats[i] * 100) / numOfRolls;
            Console.WriteLine($"{i + 2}: {new string('*', percentage)}");
        }

        Console.WriteLine("Thank you for using the dice throwing simulator. Goodbye!");
    }
}