using UnityEngine;
using System.Collections;

public class LogLife : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown("c")) {
			Debug.Log (LifeCarrier.life);
		}
	}
}
