using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace SnoWRNG.Utils;

public class Range: INotifyPropertyChanged
{
    private int _min;
    private int _max;

    public int Min
    {
        get => _min;
        set
        {
            _min = value;
            OnPropertyChanged(MinChanged);
        }
    }

    public int Max
    {
        get => _max;
        set
        {
            _max = value;
            OnPropertyChanged(MaxChanged);
        }
    }

    public Range(int min, int max)
    {
        Min = min;
        Max = max;
    }

    public override string ToString()
    {
        return $"{_min} - {_max}";
    }

    public event PropertyChangedEventHandler? PropertyChanged;
    private static readonly PropertyChangedEventArgs MinChanged = new(nameof(Min));
    private static readonly PropertyChangedEventArgs MaxChanged = new(nameof(Max));
    
    private void OnPropertyChanged(PropertyChangedEventArgs e)
    {
        PropertyChanged?.Invoke(this, e);
    }
}