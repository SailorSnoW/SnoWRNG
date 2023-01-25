using System;

namespace SnoWRNG.Utils;

public class RandomResult
{
    /// Result number of the random generation
    private int Number { get; }
    /// <summary>
    /// Input range that the user choose for the generation
    /// </summary>
    private Range Range { get; }
    /// <summary>
    /// Date of the generation
    /// </summary>
    private DateTime Date { get; }

    public RandomResult(int n, int min, int max)
    {
        Number = n;
        Range = new Range(min, max);
        Date = DateTime.Now;
    }
}