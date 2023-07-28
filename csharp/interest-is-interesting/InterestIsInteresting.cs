using System;

static class SavingsAccount
{
    public static float InterestRate(decimal balance)
    {
        switch (balance) {
            case < 0:
                return 3.213f;
            case < 1000:
                return 0.5f;
            case < 5000:
                return 1.621f;
            case >= 5000:
                return 2.475f;
        }
    }

    public static decimal Interest(decimal balance)
    {
        return (decimal)InterestRate(balance) / 100 * balance;
    }

    public static decimal AnnualBalanceUpdate(decimal balance)
    {
        return Interest(balance) + balance;
    }

    public static int YearsBeforeDesiredBalance(decimal balance, decimal targetBalance)
    {
        int years = 0;
        while (targetBalance > balance)
        {
            balance = AnnualBalanceUpdate(balance);
            years++;
        }
        return years;
    }
}
