using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class PosDown : MonoBehaviour {

    public GameObject positionDisplay;

    void OnTriggerExit(Collider other)
    {
        if (other.tag == "TagPos")
        {
            positionDisplay.GetComponent<TextMeshProUGUI>().text = "2nd Place";
        }
    }

}
