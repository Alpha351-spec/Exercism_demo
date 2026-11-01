class Lasagna
{
    // TODO: define the 'ExpectedMinutesInOven()' method
    public int ExpectedMinutesInOven(){
        return 40; 
    }
    // TODO: define the 'RemainingMinutesInOven()' method
    public int RemainingMinutesInOven(int time){
        var lasagna=new Lasagna();
        return lasagna.ExpectedMinutesInOven() - time;
    }
    // TODO: define the 'PreparationTimeInMinutes()' method
    public int PreparationTimeInMinutes(int lever){
        return lever*2; 
    }
    // TODO: define the 'ElapsedTimeInMinutes()' method
    public int ElapsedTimeInMinutes(int lever,int time){
        var lasagna=new Lasagna();
        return lasagna.PreparationTimeInMinutes(lever)+time; 
    }
}
