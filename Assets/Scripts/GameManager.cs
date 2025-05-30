using UnityEngine;

public class GameManager : MonoBehaviour
{
    private Car myCar;
    private Motorcycle myBike;

    void Start()
    {
        // create car object
        GameObject carObj = new GameObject("Car", typeof(Car));
        carObj.transform.position = new Vector3(0, 0, 0);
        carObj.AddComponent<MeshFilter>().mesh = CreateCubeMesh();
        carObj.AddComponent<MeshRenderer>().material = CreateMaterial(Color.red);
        myCar = carObj.GetComponent<Car>();
        myCar.Speed = 120;
        myCar.Fuel = 30;
        myCar.numberOfDoors = 2;

        // create motorcycle object
        GameObject bikeObj = new GameObject("Motorcycle", typeof(Motorcycle));
        bikeObj.transform.position = new Vector3(2, 0, 0);
        bikeObj.AddComponent<MeshFilter>().mesh = CreateSphereMesh();
        bikeObj.AddComponent<MeshRenderer>().material = CreateMaterial(Color.blue);
        myBike = bikeObj.GetComponent<Motorcycle>();
        myBike.Speed = 90;
        myBike.Fuel = 10;
        myBike.hasSidecar = true;

        
        myCar.StartVehicle();
        myBike.StartVehicle();
        myCar.DisplayInfo();
        myBike.DisplayInfo();
    }

    
    public void ReduceCarFuel()
    {
        myCar.Fuel -= 5;
        Debug.Log($"[CAR] New fuel: {myCar.Fuel}");
        myCar.StartVehicle(); 
    }

    public void ReduceMotorcycleFuel()
    {
        myBike.Fuel -= 3;
        Debug.Log($"[BIKE] New fuel: {myBike.Fuel}");
        myBike.StartVehicle();
    }

    private Mesh CreateCubeMesh()
    {
        GameObject temp = GameObject.CreatePrimitive(PrimitiveType.Cube);
        Mesh mesh = temp.GetComponent<MeshFilter>().mesh;
        Destroy(temp);
        return mesh;
    }

    private Mesh CreateSphereMesh()
    {
        GameObject temp = GameObject.CreatePrimitive(PrimitiveType.Sphere);
        Mesh mesh = temp.GetComponent<MeshFilter>().mesh;
        Destroy(temp);
        return mesh;
    }

    private Material CreateMaterial(Color color)
    {
        Material mat = new Material(Shader.Find("Standard"));
        mat.color = color;
        return mat;
    }
}
