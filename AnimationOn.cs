using UnityEngine;
using System.Collections;

public class AnimationOn: MonoBehaviour {

	public GameObject target;
	public Animation animacija;

	// Use this for initialization
	void Start () {
		animacija = target.GetComponent<Animation> ();
	}

	void Update(){
		animacija.Play ();
	}
}