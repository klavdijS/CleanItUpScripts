using UnityEngine;
using System.Collections;

public class SwitchCam : MonoBehaviour {

	public GameObject cameraFirstPerson;
	public Camera cameraThirdPerson;

	// Use this for initialization
	void Start () {
		cameraThirdPerson.enabled = true;
		cameraFirstPerson.SetActive (false);
	}
	
	// Update is called once per frame
	void Update () {
		
		if(Input.GetKeyDown("c")){
			if (cameraThirdPerson.enabled == true) {
				cameraThirdPerson.enabled = false;
				cameraFirstPerson.SetActive(true);
			} else {
				cameraFirstPerson.SetActive(false);
				cameraThirdPerson.enabled = true;
			}
		}

	}
}
