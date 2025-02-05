using System;
using System.Linq;

public class Program
{
    public static string ProcVowel(string param)
    {
        if (string.IsNullOrEmpty(param)) return "";
        
        string vowels = "aeiou";
        return new string(param.ToLower().Where(c => vowels.Contains(c)).ToArray());
    }

    public static string ProcConsonant(string param)
    {
        if (string.IsNullOrEmpty(param)) return "";

        string vowels = "aeiou";
        return new string(param.ToLower().Where(c => !vowels.Contains(c) && char.IsLetter(c)).ToArray());
    }

    public static string SortByFirstOccurrence(string input)
    {
        return new string(input
            .GroupBy(c => c) 
            .OrderBy(g => input.IndexOf(g.Key)) 
            .SelectMany(g => Enumerable.Repeat(g.Key, g.Count()))
            .ToArray());
    }

    public static void Main()
    {
        Console.Write("Input one line of words (S) : ");
        string? input = Console.ReadLine();

        if (string.IsNullOrEmpty(input))
        {
            Console.WriteLine("No input provided.");
            return;
        }

        string charVowel = ProcVowel(input);
        string charConsonant = ProcConsonant(input);

        Console.WriteLine("Vowel Characters :");
        Console.WriteLine(SortByFirstOccurrence(charVowel));
        Console.WriteLine("Consonant Characters :");
        Console.WriteLine(SortByFirstOccurrence(charConsonant));
    }
}
