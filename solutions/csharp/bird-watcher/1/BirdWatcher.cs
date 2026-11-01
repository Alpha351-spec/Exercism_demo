class BirdCount
{
    private int[] birdsPerDay;

    public BirdCount(int[] birdsPerDay)
    {
        this.birdsPerDay = birdsPerDay;
    }

    public static int[] LastWeek() => new int[] {0, 2, 5, 3, 7, 8, 4};

    public int Today() => birdsPerDay[^1];

    public void IncrementTodaysCount() => birdsPerDay[^1]++;

    public bool HasDayWithoutBirds()
    {
        foreach(int day_cnt in birdsPerDay){
            if(day_cnt==0){
                return true;
            }
        }
        return false;
    }

    public int CountForFirstDays(int numberOfDays)
    {
        int sum_cnt=0;
        for(int i=0;i<numberOfDays;i++){
            sum_cnt+=birdsPerDay[i];
        }
        return sum_cnt;
    }

    public int BusyDays()
    {
        int day_cnt=0;
        foreach(int cnt in birdsPerDay){
            if(cnt>=5){
                day_cnt++;
            }
        }
        return day_cnt;
    }
}
