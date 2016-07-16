using UnityEngine;

public class SpawnEnemies: MonoBehaviour {
	
	public PlayerHealth playerHealth;    
	public GameObject[] enemy;                
	public float spawnTime = 3f;           
	public Transform[] spawnPoints;         


	void Start (){
		InvokeRepeating ("Spawn", spawnTime, spawnTime);
	}


	void Spawn (){

		if(playerHealth.currentHealth <= 0f || KillTextSetter.killCount <= 0){
			return;
		}
				
			int spawnPointIndex = Random.Range (0, spawnPoints.Length);
			int randomEnemy = Random.Range (0, enemy.Length);
			Instantiate (enemy[randomEnemy], spawnPoints[spawnPointIndex].position, spawnPoints[spawnPointIndex].rotation);
	}
}