using System;
using System.Security.Cryptography;
using SnoWRNG.Utils;
using Range = SnoWRNG.Utils.Range;

namespace SnoWRNG.ViewModels;

public class MainViewModel : ViewModelBase
{
    private RandomResults History { get; } = new();
    private Range Range { get; } = new(0, 1);

    public void GenerateAndStore()
    {
        var randomNumber = GenerateInRange();

        var result = new RandomResult(randomNumber, Range.Min, Range.Max);
        History.Add(result);
    }
    
    private int GenerateInRange()
    {
        return RandomNumberGenerator.GetInt32(Range.Min, Range.Max + 1); // +1 cause max is exclusive
    }
}