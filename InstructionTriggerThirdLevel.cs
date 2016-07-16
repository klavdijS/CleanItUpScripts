using UnityEngine;
using System.Collections;

public class InstructionTriggerThirdLevel : MonoBehaviour {

	// Use this for initialization
	Animator anim;
	public GameObject canvas;
	bool wasIn = true;
	public GameObject player;
	PlayerWalking playMov;

	void Awake(){
	}
	void Start () {
		anim = canvas.GetComponent<Animator> ();
		playMov = player.GetComponent<PlayerWalking> ();
		//anim.enabled = false;
		//playMov.enabled = false;
	}

	// Update is called once per frame
	void Update () {

	}
	void OnTriggerEnter(Collider other) {
		if (other.name == "zena3lvl" && wasIn) {
			Invoke ("movementOn", 2f);
			anim.SetTrigger ("FadeIn");
			wasIn = false;
		}
	}

	void OnTriggerExit(Collider other){
		if (other.name == "zena3lvl") {
			anim.SetTrigger ("FadeOut");
			Invoke ("canvasOff", 1.8f);
		}
	}

	void canvasOff(){
		canvas.SetActive (false);
	}

	void movementOn(){
		anim.enabled = true;
		playMov.enabled = true;
	}
}

