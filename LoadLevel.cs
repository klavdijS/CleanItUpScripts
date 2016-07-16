using UnityEngine;
using System.Collections;

public class LoadLevel : MonoBehaviour {

	void OnTriggerEnter(Collider other){
		if (other.name == "zena") {
			Application.LoadLevel ("secondLevel");
		}
	}
}
