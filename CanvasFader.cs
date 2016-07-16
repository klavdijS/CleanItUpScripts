using UnityEngine;
using System.Collections;

public class CanvasFader : MonoBehaviour {

	public GameObject boss;
	GameObject player;
	public GameObject fadeIn;
	float timer = 0;
	Animator anim;
	// Use this for initialization
	void Start () {
		boss.SetActive (false);
		player = GameObject.FindGameObjectWithTag ("Player");
	}
	
	// Update is called once per frame
	void Update () {
		if (timer >= 2) {
			fadeIn.SetActive (false);
			boss.SetActive (true);
		}
		timer += Time.deltaTime;
	}
}
