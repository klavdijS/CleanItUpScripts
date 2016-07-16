using UnityEngine;
using System.Collections;

public class CloseTheDoors : MonoBehaviour {

	public GameObject target;
	Animation animacija;
	public GameObject skriptaObject;
	Counter skripta;
	public static bool imaCistilo = false;
	public GameObject setTrigger;
	BoxCollider box;
	// Use this for initialization
	void Start () {
		animacija = target.GetComponent<Animation> ();
		skripta = skriptaObject.GetComponent<Counter> ();
		box = setTrigger.GetComponent<BoxCollider> ();
		box.isTrigger = false;
	}

	void OnTriggerEnter(Collider other){
		if (other.name == "CistiloAnimacija(Clone)") {
			box.isTrigger = true;
			imaCistilo = true;
			if(skripta.timeLeft <= 10){
				skripta.timeLeft = 10;
			}
			Invoke("playAnimation",skripta.timeLeft - 3);
			Destroy (other.gameObject);
		}
	}

	void playAnimation(){
		animacija.Play ();		
	}
}
