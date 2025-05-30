
﻿using UnityEngine;

using UnityEngine;


public class GameManager : MonoBehaviour
{
    private Car myCar;
    private Motorcycle myBike;

    private Truck myTruck;



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



        // create truck object
        GameObject truckObj = new GameObject("Truck", typeof(Truck));
        truckObj.transform.position = new Vector3(4, 0, 0);
        truckObj.AddComponent<MeshFilter>().mesh = CreateCubeMesh();
        truckObj.AddComponent<MeshRenderer>().material = CreateMaterial(Color.green);
        myTruck = truckObj.GetComponent<Truck>();
        myTruck.Speed = 60;
        myTruck.Fuel = 50;
        myTruck.cargoCapacity = 5.5f;



        

        myCar.StartVehicle();
        myBike.StartVehicle();
        myCar.DisplayInfo();
        myBike.DisplayInfo();

        myTruck.DisplayInfo();


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


    public void ReduceTruckFuel()
    {
        myTruck.Fuel -= 3;
        Debug.Log($"[TRUCK] New fuel: {myTruck.Fuel}");
        myTruck.StartVehicle();
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
