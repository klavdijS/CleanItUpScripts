using UnityEngine;
using System.Collections;

public class SmokeEnabler : MonoBehaviour {

	public GameObject mainCam;
	public GameObject motionBlurCam;
	public Camera prvaKamera;
	public Camera motionKamera;

	AudioSource audio;
	void Start () {
		audio = GetComponent<AudioSource> ();
	}
	
	void OnTriggerEnter(Collider other){
		if (other.name == "zena2lvl") {
			prvaKamera.enabled = false;
			motionKamera.enabled = true;
			audio.Play ();
			//mainCam.SetActive(false);
			//motionBlurCam.SetActive(true);

		}
	}

	void OnTriggerExit(Collider other){
		if (other.name == "zena2lvl") {
			motionKamera.enabled = false;
			prvaKamera.enabled = true;
			//motionBlurCam.SetActive(false);
			//mainCam.SetActive (true);
		}
	}
}
