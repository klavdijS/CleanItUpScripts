using UnityEngine;
using System.Collections;

public class SpawnObject : MonoBehaviour {

	public Transform[] teleport;
	public GameObject prefeb;

	public void Start(){ //this will spawn only one prefeb, if you want call it many time, create  a new function and call it or create for loop

		int tele_num = Random.Range(0,6);

		Instantiate(prefeb, teleport[tele_num].position, teleport[tele_num].rotation );

	}
}
