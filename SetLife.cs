using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class SetLife : MonoBehaviour {

	public Text healthText;
	
	// Update is called once per frame
	void Update () {
		healthText.text = LifeCarrier.life.ToString ();
	}
}
