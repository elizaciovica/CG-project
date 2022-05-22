using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GlobalCar : MonoBehaviour {

    public static int CarType; //1=Red, 2=Blue

    public void RedCar ()
    {
        CarType = 1;
        //SceneManager.LoadScene (2);
    }

    public void BlueCar ()
    {
        CarType = 2;
        //SceneManager.LoadScene (2);
    }

    public void WhiteCar ()
    {
        CarType = 3;
        ///SceneManager.LoadScene (2);
    }

}
