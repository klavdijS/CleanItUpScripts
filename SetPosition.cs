using UnityEngine;
using System.Collections;

public class SetPosition : MonoBehaviour {

	public Transform kapljica;
	// Use this for initialization
	void Start () {
		kapljica.position = transform.position;
		kapljica.localScale = new Vector3 (0.25f, 0.25f, 0.25f);
	}

}
