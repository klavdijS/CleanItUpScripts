using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class KillTextSetter : MonoBehaviour {

	public static int killCount = 40;
	public GameObject portal;
	bool jePortal = false;
	public GameObject spawnPoint;

	public Text text;
	void Start(){
		killCount = 40;
	}

	void Update(){
		text.text = "You have " + killCount.ToString () + " left to kill";
		if (killCount <= 0) {
			text.text = "Proceed to next level!";
			if (!jePortal) {
				Instantiate (portal, spawnPoint.transform.position, spawnPoint.transform.rotation);
				jePortal = true;
			}
		}
	}

}
