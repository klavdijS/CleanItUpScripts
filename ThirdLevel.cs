using UnityEngine;
using System.Collections;

public class ThirdLevel : MonoBehaviour {

	GameObject player;
	PlayerMovement playMov;
	Animator anim;
	void Awake(){
		player = GameObject.FindWithTag ("Player");
		playMov = player.GetComponent<PlayerMovement> ();
		anim = player.GetComponent<Animator> ();
	}
	void OnTriggerStay(Collider other){
		if (other.name == "zena2lvl") {
			Invoke ("loadNextLevel", 2f);
			playMov.enabled = false;
			anim.SetBool ("IsWalking", false);
		}
	}

	void loadNextLevel(){
		//Application.LoadLevel ("thirdLevel");
		Debug.Log("NextLVL");
	}
}
