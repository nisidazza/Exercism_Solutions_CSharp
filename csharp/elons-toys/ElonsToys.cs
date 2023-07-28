using System;

class RemoteControlCar
{
    private int _distance = 0;
    private int _batteryLevel = 100;
    
    public static RemoteControlCar Buy()
    {
        return new RemoteControlCar();
    }

    public string DistanceDisplay()
    {
        return $"Driven {_distance} meters";
    }

    public string BatteryDisplay()
    {
        return _batteryLevel == 0 ? "Battery empty" : $"Battery at {_batteryLevel}%";
    }

    public void Drive()
    {
        if(_batteryLevel > 0) 
        {
            _distance += 20;
            _batteryLevel--;
        }
        
    }
}
