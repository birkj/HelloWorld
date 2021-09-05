using System;

public class YearLessThan1582Exception : Exception
{
    public YearLessThan1582Exception()
    {
    }

    public YearLessThan1582Exception(string message)
        : base(message)
    {
    }

    public YearLessThan1582Exception(string message, Exception inner)
        : base(message, inner)
    {
    }
}