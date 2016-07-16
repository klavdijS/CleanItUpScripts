using UnityEngine;
using System.Collections;

public class LightsOn : MonoBehaviour {

	float timer = 0;
	public GameObject kratekStik;
	public GameObject luci;
	bool triggerLight = false;

	void OnTriggerEnter(Collider other){
		if (other.name == "zena2lvl") {
			if (triggerLight == false) {
				timer = 0;
				kratekStik.SetActive (true);
				Invoke ("kratkiStiki", 1f);
				Invoke ("ugasniKratekStik", 11f);
				triggerLight = true;
			}
		}
	}

	void ugasniKratekStik(){
		luci.SetActive (true);
		triggerLight = false;
	}
	void kratkiStiki(){
		kratekStik.SetActive (false);
		luci.SetActive (false);
	}
}
