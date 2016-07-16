using UnityEngine;
using System.Collections;

public class HealthPackSpawner: MonoBehaviour {

	public Transform[] teleport;
	public GameObject prefab;

	public float spawnTime = 10f;

	public float spawnTimerAfter = 5f;

	void Start (){
		InvokeRepeating ("Spawn", spawnTime, spawnTimerAfter);
	}

	void Spawn (){

		if(LifeCarrier.life <= 0f || KillTextSetter.killCount <= 0){
			return;
		}

		int spawnPointIndex = Random.Range (0, teleport.Length);
		Instantiate (prefab, teleport[spawnPointIndex].position, teleport[spawnPointIndex].rotation);
	}
		
}

