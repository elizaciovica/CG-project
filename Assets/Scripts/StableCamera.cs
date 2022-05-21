using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StableCamera : MonoBehaviour {
    public GameObject MyCar;
    public float CarX;
    public float CarY;
    public float CarZ; 

    void Update() {   
        CarX = MyCar.transform.eulerAngles.x;
        CarY = MyCar.transform.eulerAngles.y;
        CarZ = MyCar.transform.eulerAngles.z;

        transform.eulerAngles = new Vector3(CarX - CarX, CarY, CarZ - CarZ);
        
    }
}
