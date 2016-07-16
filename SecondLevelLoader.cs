using UnityEngine;
using System.Collections;

public class SecondLevelLoader : MonoBehaviour {

	void OnTriggerEnter(Collider other){
		if (other.name == "zena" && CloseTheDoors.imaCistilo == true) {
			LifeCarrier.endLife = LifeCarrier.life;
			Application.LoadLevel ("secondLevel");
		}
	}
}
