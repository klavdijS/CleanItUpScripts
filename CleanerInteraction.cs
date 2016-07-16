using UnityEngine;
using System.Collections;

public class CleanerInteraction : MonoBehaviour {

	public Canvas canvas;
	Animator anim;

	void Start(){
		anim = canvas.GetComponentInChildren<Animator> ();
		canvas.enabled = false;
	}
	void OnTriggerEnter(Collider other){
		if (other.name == "zena" && CloseTheDoors.imaCistilo == false) {
			anim.SetTrigger ("FadeIn");
			canvas.enabled = true;
		}
	}
	void OnTriggerExit(Collider other){
		if (other.name == "zena" && CloseTheDoors.imaCistilo == false) {
			anim.SetTrigger ("FadeOut");
			canvas.enabled = false;
		}
	}
}
