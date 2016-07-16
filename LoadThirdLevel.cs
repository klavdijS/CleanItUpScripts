using UnityEngine;
using System.Collections;

public class LoadThirdLevel : MonoBehaviour {

	public GameObject player;
	PlayerMovement playMov;
	Animator anim;

	// Use this for initialization
	void Start () {
		player = GameObject.FindGameObjectWithTag ("Player");	
		playMov = player.GetComponent<PlayerMovement> ();
		anim = player.GetComponent<Animator> ();
	}

	void OnTriggerEnter(Collider other){
		if (other.name == "zena2lvl") {
			playMov.enabled = false;
			anim.enabled = false;
			Invoke ("loadnextLvl", 2f);
		}
	}

	void loadnextLvl(){
		Application.LoadLevel ("thirdLevels");
	}
}
