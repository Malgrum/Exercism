static class SavingsAccount
{
    public static float InterestRate(decimal balance)
    {
        if (balance < 0)
        {
            return 3.213f;
        }
        else if (balance < 1000)
        {
            return 0.5f;
        }
        else if (balance < 5000)
        {
            return 1.621f;
        }
        else
        {
            return 2.475f;
        }
    }

    public static decimal Interest(decimal balance)
    {
        decimal interest = balance * ((decimal)InterestRate(balance)/100m);
        return interest;
    }

    public static decimal AnnualBalanceUpdate(decimal balance)
    {
        decimal total = balance + ((decimal)Interest(balance));
            return total;
    }

    public static int YearsBeforeDesiredBalance(decimal balance, decimal targetBalance)
{
    int year = 0;

    while (balance < targetBalance)
    {
        balance += Interest(balance); // ajouter les intérêts
        year++;                       // incrémenter le nombre d'années
    }

    return year;
}

}
