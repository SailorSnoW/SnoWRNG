using System.Collections.ObjectModel;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;

namespace SnoWRNG.Utils;

public class RandomResults: ObservableCollection<RandomResult>
{
    public RandomResult? LastResult => this.LastOrDefault();
    
    protected override void InsertItem(int index, RandomResult item)
    {
        base.InsertItem(index, item);
        
        // LastResult is refreshed when a new result is added to the collection
        // and an event is emitted to propagate to the UI.
        OnPropertyChanged(EventArgsCache.LastResultChanged);
    }
}

internal static class EventArgsCache
{
    internal static readonly PropertyChangedEventArgs LastResultChanged = new("LastResult");
}