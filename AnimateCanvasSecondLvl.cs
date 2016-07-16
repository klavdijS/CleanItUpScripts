using UnityEngine;
using System.Collections;

public class AnimateCanvasSecondLvl : MonoBehaviour {

	public GameObject canvas;
	Animator anim;
	public GameObject player;
	PlayerMovement scripta;
	Animator playerAnim;

	// Use this for initialization
	void Start () {
		anim = canvas.GetComponent<Animator> ();
		anim.SetTrigger ("BlackScreen");
		scripta = player.GetComponent<PlayerMovement> ();
		scripta.enabled = false;
		playerAnim = player.GetComponent<Animator> ();
		playerAnim.enabled = false;
		Invoke ("controllersOn", 3f);
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