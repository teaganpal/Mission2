namespace Mission2;

public class Rolling
{
    public Rolling()
    {
        // empty constructor
    }
    
    // Dice Simulator Method
    public int[] DiceSimulator(int numOfRolls)
    {
        // creating array
        int[] rollsStats = new int[11];

        // initializing array
        for (int i = 0; i < rollsStats.Length; i++)
        {
            rollsStats[i] = 0;
        }

        // rolling dice, adding results, updating array
        for (int i = 0; i < numOfRolls; i++)
        {
            Random random = new Random();
            int dice1 = random.Next(1, 7);
            int dice2 = random.Next(1, 7);
            int addedRoll = dice1 + dice2;
            rollsStats[(addedRoll - 2)] += 1;
        }
        
        // returns array with results
        return rollsStats;
    }
}