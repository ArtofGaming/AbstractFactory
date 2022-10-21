using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IVehicle
{
    public static IVehicle GetVehicle(VehicleRequirements requirements)
    {
        //var factory = new VehicleFactory(requirements);

        VehicleFactory factory = new VehicleFactory(requirements);
        return factory.Create();

    }
}
public class Unicycle : IVehicle { }
public class Bicycle : IVehicle { }
public class Tandem : IVehicle { }
public class Tricycle : IVehicle { }
public class GoKart : IVehicle { }
public class FamilyBike : IVehicle { }
public class Car : IVehicle { }
public class Motorbike : IVehicle { }
public class Truck : IVehicle { }

