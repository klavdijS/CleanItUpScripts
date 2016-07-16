using UnityEngine;
using System.Collections;

public class AnimateCanvas : MonoBehaviour {

	public GameObject canvas;
	Animator anim;
	public GameObject player;
	scrip scripta;
	Animator playerAnim;

	// Use this for initialization
	void Start () {
		anim = canvas.GetComponent<Animator> ();
		anim.SetTrigger ("BlackScreen");
		scripta = player.GetComponent<scrip> ();
		scripta.enabled = false;
		playerAnim = player.GetComponent<Animator> ();
		playerAnim.enabled = false;
		Invoke ("controllersOn", 2f);
	}

	void controllersOn(){
		scripta.enabled = true;
		playerAnim.enabled = true;
		canvas.SetActive (false);
	}
	// Update is called once per frame
	void Update () {
	
	}
}
