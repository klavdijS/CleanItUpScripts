using UnityEngine;
using System.Collections;

public class Interaction : MonoBehaviour {

	private Animator menuAnim;
	public Canvas interaction;
	public GameObject script;
	SpawnObject spawner;
	Counter counter;
	public Canvas timer;

	// Use this for initialization
	void Start () {
		menuAnim = interaction.GetComponentInChildren<Animator> ();
		interaction.enabled = false;
		spawner = script.GetComponent<SpawnObject> ();
		timer.enabled = false;
		counter = timer.GetComponentInChildren<Counter> ();
	}
	
	// Update is called once per frame
	void Update () {
	
	}

	void OnTriggerEnter(Collider other){
		if (other.name == "KapljicaTrigger") {
			menuAnim.SetTrigger ("FadeIn");
			interaction.enabled = true;
		}
	}

	void OnTriggerExit(Collider other){
		if (other.name == "KapljicaTrigger") {
			menuAnim.SetTrigger ("FadeOut");
			interaction.enabled = false;
		}

		if (other.name == "SpawnCleaner") {
			spawner.Start ();
			timer.enabled = true;
			counter.enabled = true;
		}
	}
}
