﻿using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class BossHealthSetter : MonoBehaviour {

	public Text text;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		text.text ="Boss health left: " + BossHealth.currentHealth.ToString ();
	}
}
