using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HalfComplete : MonoBehaviour {

    public GameObject LapCompleteTrig;
	public GameObject HalfLapTrig;

    void OnTriggerEnter() {
        LapCompleteTrig.SetActive(true);
        HalfLapTrig.SetActive(false);

        Debug.Log("Trigger!");
    }
}
