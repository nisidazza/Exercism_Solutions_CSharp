using System;

class RemoteControlCar
{
    private int _speed;
    private int _currentSpeed;
    private int _batteryDrain;
    private int _batteryLevel;

    public RemoteControlCar(int speed, int batteryDrain)
    {
        _speed = speed;
        _batteryDrain = batteryDrain;
        _batteryLevel = 100;
    }


    public bool BatteryDrained()
    {
        return _batteryDrain > _batteryLevel;
    }

    public int DistanceDriven()
    {
        return _currentSpeed;
    }

    public void Drive()
    {
        if (!BatteryDrained())
        {
            _currentSpeed += _speed;
        }

        _batteryLevel -= _batteryDrain;

    }

    public static RemoteControlCar Nitro()
    {
        return new RemoteControlCar(50, 4);
    }
}

class RaceTrack
{
    private int _distance;

    public RaceTrack(int distance)
    {
        _distance = distance;
    }

    public bool TryFinishTrack(RemoteControlCar car)
    {
        while (!car.BatteryDrained())
        {
            car.Drive() ;
        }

        return car.DistanceDriven() >= _distance;
    }
        
}
