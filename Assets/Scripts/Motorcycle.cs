using UnityEngine;

public class Motorcycle : Vehicle
{
    public bool hasSidecar = false;

    public override void DisplayInfo()
    {
        Debug.Log($"Motorcycle Info: Speed={Speed}, Fuel={Fuel}, Has Sidecar={hasSidecar}");
    }
}
