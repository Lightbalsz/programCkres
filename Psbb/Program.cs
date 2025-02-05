using System;
using System.Linq;

class Program
{
    static void Main()
    {
        // Input the number of families
        Console.Write("Input the number of families: ");
        string? nInput = Console.ReadLine();
        
        // Check if input is null or invalid
        if (string.IsNullOrEmpty(nInput) || !int.TryParse(nInput, out int n))
        {
            Console.WriteLine("Invalid input for number of families.");
            return;
        }

        // Input the number of family members
        Console.Write("Input the number of members in the family (separated by a space): ");
        string? membersInput = Console.ReadLine();

        // Check if input is null or empty
        if (string.IsNullOrEmpty(membersInput))
        {
            Console.WriteLine("Invalid input for family members.");
            return;
        }

        // Split the input into array and validate
        string[] familyMembersInput = membersInput.Split(' ');
        
        // Validate the number of families
        if (familyMembersInput.Length != n)
        {
            Console.WriteLine("Input must be equal with count of family");
            return;
        }

        // Convert the input into integer array
        int[] familyMembers = new int[n];
        for (int i = 0; i < n; i++)
        {
            if (!int.TryParse(familyMembersInput[i], out familyMembers[i]) || familyMembers[i] <= 0)
            {
                Console.WriteLine("Invalid number of members in one of the families.");
                return;
            }
        }

        // Calculate the total number of members
        int totalMembers = familyMembers.Sum();

        // Calculate the minimum buses required
        int busesRequired = (totalMembers + 3) / 4; // This formula rounds up the division

        Console.WriteLine($"Minimum bus required is: {busesRequired}");
    }
}
