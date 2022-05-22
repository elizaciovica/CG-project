using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityStandardAssets.Vehicles.Car;

public class Countdown : MonoBehaviour {

	public GameObject CountDown;
	public AudioSource GetReady;
	public AudioSource GoAudio;
	public GameObject LapTimer;
	public GameObject Car;
	public GameObject CarAI;

	void Start () {
		StartCoroutine (CountStart ());		
	}


	IEnumerator CountStart () {
		yield return new WaitForSeconds (0.5f);
		CountDown.GetComponent<TextMeshProUGUI> ().text = "3";
		GetReady.Play ();
		CountDown.SetActive (true);
		yield return new WaitForSeconds (1);
		CountDown.SetActive (false);
		CountDown.GetComponent<TextMeshProUGUI> ().text = "2";
		GetReady.Play ();
		CountDown.SetActive (true);
		yield return new WaitForSeconds (1);
		CountDown.SetActive (false);
		CountDown.GetComponent<TextMeshProUGUI> ().text = "1";
		GetReady.Play ();
		CountDown.SetActive (true);
		yield return new WaitForSeconds (1);
		CountDown.SetActive (false);
		GoAudio.Play ();
        Car.GetComponent<CarController> ().enabled = true;
		CarAI.GetComponent<CarAIControl> ().enabled = true;

		LapTimer.SetActive (true);

	}
	

}
