using UnityEngine;

public class Truck : Vehicle
{
    public float cargoCapacity; // in tons

    public override void DisplayInfo()
    {
        Debug.Log($"[TRUCK] Speed: {Speed} km/h | Fuel: {Fuel} L | Cargo Capacity: {cargoCapacity} tons");
    }
}
