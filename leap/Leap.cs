public static class Leap
{
    public static bool IsLeapYear(int year)
    {
        return isEvenly(year, 4) 
            && (!isEvenly(year, 100) || isEvenly(year, 400));
    }

    private static bool isEvenly(int number1, int number2)
    {
        return number1 % number2 == 0;
    }
}