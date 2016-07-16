using UnityEngine;
using System.Collections;

public class KillCounterOn : MonoBehaviour {

	bool shown = false;
	public GameObject go;
	Animator anim;
	// Use this for initialization
	void Start () {
		anim = go.GetComponent<Animator> ();
		anim.SetBool ("Prikazano", shown);
		Invoke ("turnOff", 3f);
	}

	void turnOff(){
		shown = true;
		anim.SetBool ("Prikazano", shown);
	}
}
