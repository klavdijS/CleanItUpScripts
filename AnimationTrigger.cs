using UnityEngine;
using System.Collections;

public class AnimationTrigger : MonoBehaviour {

	public GameObject target;
	public Animation animacija;
	// Use this for initialization
	void Start () {
		animacija = target.GetComponent<Animation> ();
	}

	void OnTriggerEnter(Collider other){
		if (other.name == "Cube") {
			Invoke("playAnimation",3f);
			Destroy (other.gameObject);
		}
	}
	
	void playAnimation(){
		animacija.Play ();		
	}
}
