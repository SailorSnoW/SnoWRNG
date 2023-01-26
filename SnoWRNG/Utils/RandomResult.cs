using System;
using System.Globalization;

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

    public string Serialized => ToString();
    
    public override string ToString()
    {
        return $"Number {Number} was generated the " +
               $"{Date.ToString(new CultureInfo("en-US"))}. \n" +
               $"(Range: {Range})";
    }
}