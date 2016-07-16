using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class menuScript : MonoBehaviour {

	public Button startText;
	public Button exitText;

	// Use this for initialization
	void Start () {
		//startText = startText.GetComponent<Button> ();
		//exitText = exitText.GetComponent<Button> ();
	}
	
	public void ExitPress(){
		Application.Quit ();
	}

	public void NoPress(){
		startText.enabled = true;
		exitText.enabled = true;
	}

	public void StartLevel(){
		Application.LoadLevel (1);
	}
}
