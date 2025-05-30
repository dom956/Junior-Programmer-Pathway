using UnityEngine;

public abstract class Vehicle : MonoBehaviour
{
    
    private float _speed;
    private float _fuel;

    
    public float Speed
    {
        get { return _speed; }
        set { _speed = Mathf.Clamp(value, 0, 300); }
    }

    public float Fuel
    {
        get { return _fuel; }
        set { _fuel = Mathf.Max(0, value); }
    }

    
    public void StartVehicle()
    {
        if (Fuel > 0)
        {
            Debug.Log($"{GetType().Name} started. Vroom!");
        }
        else
        {
            Debug.Log($"{GetType().Name} can't start. No fuel!");
        }
    }

    
    public abstract void DisplayInfo();
}
