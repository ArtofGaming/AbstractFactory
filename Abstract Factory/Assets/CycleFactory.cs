using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CycleFactory : IVehicleFactory
{
    public IVehicle Create (VehicleRequirements requirements)
    {
        switch (requirements.Passengers)
        {
            case 1:
                if(requirements.NumberOfWheels == 1)
                {
                    Debug.Log("Unicycle");
                    return new Unicycle();
                }
                return new Bicycle();
            case 2:
                return new Tandem();
            case 3:
                return new Tricycle();
            case 4:
                return new FamilyBike();
            default:
                Debug.Log("Bicycle");
                return new Bicycle();
        }
    }
}
