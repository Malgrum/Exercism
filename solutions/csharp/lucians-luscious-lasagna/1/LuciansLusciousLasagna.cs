class Lasagna
{
    // TODO: define the 'ExpectedMinutesInOven()' method
    public int ExpectedMinutesInOven()
    {
        return 40;
    }
    
    // TODO: define the 'RemainingMinutesInOven()' method
    public int RemainingMinutesInOven(int n)
    {
        return 40-n;
    }

    // TODO: define the 'PreparationTimeInMinutes()' method
    public int PreparationTimeInMinutes(int y)
    {
        return 2 * y;
    }
    
    // TODO: define the 'ElapsedTimeInMinutes()' method
    public int ElapsedTimeInMinutes(int a, int b)
    {
        return PreparationTimeInMinutes(a) + b;
    }
}