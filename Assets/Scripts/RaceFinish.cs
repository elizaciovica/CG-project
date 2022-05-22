using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Vehicles.Car;
using TMPro;

public class RaceFinish : MonoBehaviour {

	public GameObject MyCar;
	public GameObject FinishCam;
	public GameObject ViewModes;
	public GameObject CompleteTrig;
    public GameObject Time;
	public AudioSource FinishMusic;
    public GameObject positionDisplay;
    public GameObject positionDisplay1;
    public GameObject Back;
    public GameObject Retry;

	void OnTriggerEnter (Collider other) {
        if (other.tag == "AICar01")
        {
            positionDisplay.GetComponent<TextMeshProUGUI>().text = "2st Place. The other player finished the game. YOU LOST!";
            this.GetComponent<BoxCollider> ().enabled = false;
            MyCar.SetActive (false);
            CompleteTrig.SetActive (false);
            positionDisplay1.SetActive (false);
            Back.SetActive (true);
            Retry.SetActive (true);
            Time.SetActive (false);
            MyCar.GetComponent<CarController> ().enabled = false;
            MyCar.GetComponent<CarUserControl> ().enabled = false;
            MyCar.SetActive (true);
            FinishCam.SetActive (true);
            ViewModes.SetActive (false);
            FinishMusic.Play ();
        }
        if (other.tag == "TagPos")
        {
            positionDisplay.GetComponent<TextMeshProUGUI>().text = "1st Place. YOU WON!";
            this.GetComponent<BoxCollider> ().enabled = false;
            MyCar.SetActive (false);
            CompleteTrig.SetActive (false);
            positionDisplay1.SetActive (false);
            Back.SetActive (true);
            Retry.SetActive (true);
            Time.SetActive (false);
            MyCar.GetComponent<CarController> ().enabled = false;
            MyCar.GetComponent<CarUserControl> ().enabled = false;
            MyCar.SetActive (true);
            FinishCam.SetActive (true);
            ViewModes.SetActive (false);
            FinishMusic.Play ();
        }
	}

}
