using System;

public static class Gigasecond
{
    const int GIGASECOND = 1_000_000_000;
    public static DateTime Add(DateTime moment) => moment.AddSeconds(GIGASECOND);
}