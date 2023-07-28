using System;

class BirdCount
{
    private int[] birdsPerDay;

    public BirdCount(int[] birdsPerDay)
    {
        this.birdsPerDay = birdsPerDay;
    }

    public static int[] LastWeek()
    {
        return new int[] {0, 2, 5, 3, 7, 8, 4};
    }

    public int Today()
    {
        
       return birdsPerDay[birdsPerDay.Length - 1];
    }

    public void IncrementTodaysCount()
    {
      birdsPerDay[birdsPerDay.Length - 1] += 1;
    }

    public bool HasDayWithoutBirds()
    {
        return Array.Exists(birdsPerDay, bird => bird == 0);
    }

    public int CountForFirstDays(int numberOfDays)
    {
        var count = 0;
        for(var i = 0; i < numberOfDays; i++) {
            count += birdsPerDay[i];
        }
        return count;
    }

    public int BusyDays()
    {
        
        var busyDays = 0;
        foreach(int bird in birdsPerDay) 
        {
            if(bird >= 5) 
            {
                busyDays++;
            }
        }
        return busyDays;
    }
}
