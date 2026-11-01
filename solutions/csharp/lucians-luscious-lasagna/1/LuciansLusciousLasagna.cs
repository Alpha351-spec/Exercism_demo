class Lasagna
{
    // TODO: define the 'ExpectedMinutesInOven()' method
    public int ExpectedMinutesInOven(){
        int time = 40;
        return time; 
    }
    // TODO: define the 'RemainingMinutesInOven()' method
    public int RemainingMinutesInOven(int time){
        var lasagna=new Lasagna();
        int s_time = lasagna.ExpectedMinutesInOven() - time;
        return s_time; 
    }
    // TODO: define the 'PreparationTimeInMinutes()' method
    public int PreparationTimeInMinutes(int lever){
        int lever_time=lever*2;
        return lever_time; 
    }
    // TODO: define the 'ElapsedTimeInMinutes()' method
    public int ElapsedTimeInMinutes(int lever,int time){
        var lasagna=new Lasagna();
        int time_consuming=lasagna.PreparationTimeInMinutes(lever)+time;
        return time_consuming; 
    }
}
