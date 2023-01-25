using System;
using ReactiveUI;
using SnoWRNG.Utils;

namespace SnoWRNG.ViewModels;

public class MainViewModel : ViewModelBase
{
    private RandomResults _history { get; } = new();
    private int _min;
    private int _max = 1;

    public int Min
    {
        get => _min;
        set => this.RaiseAndSetIfChanged(ref _min, value);
    }
    public int Max
    {
        get => _max;
        set => this.RaiseAndSetIfChanged(ref _max, value);
    }

    public void GenerateAndStore()
    {
        var randomNumber = GenerateInRange();

        var result = new RandomResult(randomNumber, _min, _max);
        _history.Add(result);
    }
    
    private int GenerateInRange()
    {
        var rand = new Random();

        return rand.Next(_min, _max + 1); // +1 cause max is exclusive
    }
}