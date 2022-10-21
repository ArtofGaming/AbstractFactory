using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MotorVehicleFactory : IVehicleFactory
{
    public IVehicle Create(VehicleRequirements requirements)
    {
        switch (requirements.Passengers)
        {
            case 1:
                return new Motorbike();
            case 2:
                return new Car();
            default:
                return new Truck();
        }
    }
}
