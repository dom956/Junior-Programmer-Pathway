using UnityEngine;

public class Car : Vehicle
{
    public int numberOfDoors = 4;

    public override void DisplayInfo()
    {
        Debug.Log($"Car Info: Speed={Speed}, Fuel={Fuel}, Doors={numberOfDoors}");
    }
}
