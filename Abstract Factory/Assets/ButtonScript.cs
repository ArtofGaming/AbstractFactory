using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonScript : MonoBehaviour
{
    private void Start()
    {
        VehicleRequirements requirements = new VehicleRequirements();
    }
    public VehicleRequirements requirements;
    public void GetVehicle()
    {
        //var factory = new VehicleFactory(requirements);

        IVehicle vehicle = GetVehicle(requirements);
        Debug.Log(vehicle);
        //ReturnFactory(requirements);
        

    }
    public IVehicle GetVehicle(VehicleRequirements requirements)
    {
        VehicleFactory factory = new VehicleFactory(requirements);
        return factory.Create();
    }
}
