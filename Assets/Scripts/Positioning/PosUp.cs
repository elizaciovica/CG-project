using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PosUp : MonoBehaviour {

    public GameObject positionDisplay;

    void OnTriggerExit(Collider other)
    {
        if (other.tag == "TagPos")
        {
            positionDisplay.GetComponent<TextMeshProUGUI>().text = "1st Place";
        }
    }

}