static class AssemblyLine
{
    public static double SuccessRate(int speed)
    {
        if (speed == 0)
        {
            return 0.00;
        }

        else if (1 <= speed && speed <= 4)
        {
            return 1.00;
        }
         else if (5 <= speed && speed <= 8)
        {
            return 0.9;
        }
        else if (speed == 9)
        {
            return 0.8;
        }
        else if (speed == 10)
        {
            return 0.77;
        }
        return 0;
    }
    
    public static double ProductionRatePerHour(int speed)
    {
        double total = 221 * speed;
        return total * SuccessRate(speed);
    }

    public static int WorkingItemsPerMinute(int speed)
{
    double min = 221.0 / 60;
    double total = min * speed * SuccessRate(speed);
    return (int)total;
}

}
