using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class Counter : MonoBehaviour {

	public Text timer;
	public float timeLeft = 30;
	string time;
	public GameObject gameOver;
	//public Camera disable;
	Animator anim;
	public GameObject player;
	scrip script;
	AudioSource audio;
	// Use this for initialization
	void Start () {
		audio = player.GetComponent<AudioSource> ();
		anim = player.GetComponent<Animator> ();
		script = player.GetComponent<scrip> ();
	}
	
	// Update is called once per frame
	void Update () {
		if (timeLeft > 0) {
			timeLeft -= Time.deltaTime;
			time = timeLeft.ToString("##.#");
			timer.text = "You have " +time+" seconds left";
		}
		if (timeLeft <= 0) {
			audio.Play ();
			GameOver ();
		}
	}

	public void GameOver(){
		audio.Play ();
		anim.SetBool ("IsDead", true);
		timer.text = "Out of time";
		script.enabled = false;
		Invoke ("SetBG", 8f);
	}

	void SetBG(){
		gameOver.SetActive (true);
	}
}
