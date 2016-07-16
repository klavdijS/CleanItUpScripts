using UnityEngine;
using System.Collections;

public class InstructionTrigger : MonoBehaviour {

	// Use this for initialization
	Animator anim;
	public GameObject canvas;
	bool wasIn = true;
	public GameObject player;
	PlayerMovement playMov;
	void Start () {
		anim = canvas.GetComponent<Animator> ();
		playMov = player.GetComponent<PlayerMovement> ();
		playMov.enabled = false;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	void OnTriggerEnter(Collider other) {
		if (other.name == "zena2lvl" && wasIn) {
			Invoke ("movementOn", 2f);
			anim.SetTrigger ("FadeIn");
			wasIn = false;
		}
	}

	void OnTriggerExit(Collider other){
		if (other.name == "zena2lvl") {
			anim.SetTrigger ("FadeOut");
			Invoke ("canvasOff", 1.8f);
		}
	}
	
	void canvasOff(){
		canvas.SetActive (false);
	}

	void movementOn(){
		playMov.enabled = true;
	}
}
