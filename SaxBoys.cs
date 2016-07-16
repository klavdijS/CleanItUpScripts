using UnityEngine;
using System.Collections;

public class SaxBoys : MonoBehaviour {

	AudioSource source;
	public GameObject luci;
	bool luciVklopljene = false;
	float timer;
	// Use this for initialization
	void Start () {
		source = GetComponent<AudioSource> ();
	}

	void Update(){
		
		if (luciVklopljene) {
			if (timer <= 1) {
				luci.SetActive (true);
			}
			if (timer > 2) {
				luci.SetActive (false);
			}
			if (timer >= 3) {
				timer = 0;
			}
		}
		if (!luciVklopljene) {
			luci.SetActive (false);
		}
		timer += Time.deltaTime;
		
	}
	void OnTriggerEnter(Collider other){
		if (other.name == "zena2lvl") {
			luciVklopljene = true;
			source.Play ();
		}
	}

	void OnTriggerExit(Collider other){
		if (other.name == "zena2lvl") {
			luciVklopljene = false;

			source.Stop ();
		}
	}
}
