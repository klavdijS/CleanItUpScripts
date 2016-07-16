using UnityEngine;
using System.Collections;

public class LifeCarrier : MonoBehaviour {

	public static int life = 100;
	public static int endLife;
	// Use this for initialization

	void Awake(){
	}
	void Start () {
	}

	public void LogLife(){
	}
	// Update is called once per frame
	void Update () {
		endLife = life;
	
	}
}
