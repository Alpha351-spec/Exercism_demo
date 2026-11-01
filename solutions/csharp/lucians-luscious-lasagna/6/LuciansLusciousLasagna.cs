class Lasagna
{
    // TODO: define the 'ExpectedMinutesInOven()' method
    public int ExpectedMinutesInOven() => 40; 
    // TODO: define the 'RemainingMinutesInOven()' method
    public int RemainingMinutesInOven(int time) => ExpectedMinutesInOven() - time;
    // TODO: define the 'PreparationTimeInMinutes()' method
    public int PreparationTimeInMinutes(int lever) => lever*2; 
    // TODO: define the 'ElapsedTimeInMinutes()' method
    public int ElapsedTimeInMinutes(int lever,int time) => PreparationTimeInMinutes(lever)+time; 
}
