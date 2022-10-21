using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class VehicleRequirements : MonoBehaviour
{
    public int NumberOfWheels;
    public bool HasEngine;
    public int Passengers;
    public TMP_Dropdown wheelSetter;
    public TMP_Dropdown passengerSetter;
    public TMP_Dropdown engineSetter;

    public void SetWheels()
    {
        NumberOfWheels = int.Parse(wheelSetter.captionText.text);
    }

    public void SetPassengers()
    {
        Passengers = int.Parse(passengerSetter.captionText.text);
    }

    public void SetEngine()
    {
        HasEngine = bool.Parse(engineSetter.captionText.text);
    }

}
