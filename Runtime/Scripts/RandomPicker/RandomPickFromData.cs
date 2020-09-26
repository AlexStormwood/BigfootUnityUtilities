using System;

public class RandomPickFromData
{
    public static T PickRandomOneFromData<T>(T[] incomingData)
    {
        return incomingData[new Random().Next(incomingData.Length)];
    }
}
