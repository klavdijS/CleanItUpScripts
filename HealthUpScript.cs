using UnityEngine;
using System.Collections;

public class HealthUpScript : MonoBehaviour {

	int life;

	void OnTriggerEnter(Collider other){
		if (other.name == "zena2lvl") {
			if (LifeCarrier.life > 90) {
				life = 100 - LifeCarrier.life;
				LifeCarrier.life += life;
			} else {
				LifeCarrier.life += 10;
			}
			Destroy (this.gameObject);
		}
	}

}
