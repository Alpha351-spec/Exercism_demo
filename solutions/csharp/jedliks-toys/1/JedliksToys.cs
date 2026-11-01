class RemoteControlCar
{
    public int bat=100;
    public int meters=0;
    
    public static RemoteControlCar Buy() => new RemoteControlCar();

    public string DistanceDisplay() => $"Driven {meters} meters";

    public string BatteryDisplay() => bat==0 ? $"Battery empty":$"Battery at {bat}%";

    public void Drive()
    {
        if(bat > 0) {
            meters+=20;
            bat-=1;
            return;
        }
    }
}
