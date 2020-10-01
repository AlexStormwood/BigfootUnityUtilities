using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;

public class RandomPickFromData
{
    public static T PickRandomOneFromData<T>(T[] incomingData)
    {
        return incomingData[new Random().Next(incomingData.Length)];
    }

    public static T PickRandomOneFromData<T>(List<T> incomingData)
    {
        return incomingData[new Random().Next(incomingData.Count)];
    }

    public static T PickRandomOneFromData<T>(Queue<T> incomingData)
    {
        return PickRandomOneFromData(incomingData.ToArray());
    }

    public static T PickRandomOneFromData<T>(Stack<T> incomingData)
    {
        return PickRandomOneFromData(incomingData.ToArray());
    }

    public static T PickRandomOneFromData<T>(ObservableCollection<T> incomingData)
    {
        T[] tempArray = new T[0];
        incomingData.CopyTo(tempArray, 0);
        return PickRandomOneFromData(tempArray);
    }

    public static T PickRandomOneFromData<T>(LinkedList<T> incomingData)
    {
        T[] tempArray = new T[0];
        incomingData.CopyTo(tempArray, 0);
        return PickRandomOneFromData(tempArray);
    }


}
