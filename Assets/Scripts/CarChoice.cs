using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarChoice : MonoBehaviour {

    public GameObject RedBody;
    public GameObject BlueBody;
    public GameObject WhiteBody;
    public int CarImport;

	void Start () {
        CarImport = GlobalCar.CarType;
        if (CarImport == 1)
        {
            WhiteBody.SetActive(false);
            RedBody.SetActive(true);
        }

        if (CarImport == 2)
        {
            WhiteBody.SetActive(false);
            BlueBody.SetActive(true);
        }

        if (CarImport == 3)
        {
            WhiteBody.SetActive(true);
        }
        
	}

}