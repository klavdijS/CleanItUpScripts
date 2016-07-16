using UnityEngine;
using System.Collections;


public class EnemyAttack : MonoBehaviour {
	public float timeBetweenAttacks = 0.5f;  
	public int attackDamage = 10;               

	GameObject player;                         
	PlayerHealth playerHealth;                 
	BakterijaHealth enemyHealth;                
	bool playerInRange;                       
	float timer;                                
	NavMeshAgent navMesh;
	EnemyMovement moveScript;

	void Awake () {
		
		player = GameObject.FindGameObjectWithTag ("Player");
		playerHealth = player.GetComponent <PlayerHealth> ();
		enemyHealth = GetComponent<BakterijaHealth>();
		navMesh = GetComponent<NavMeshAgent>();
		moveScript = GetComponent<EnemyMovement> ();

	}


	void OnTriggerEnter (Collider other) {
		if(other.gameObject == player) {
			
			playerInRange = true;
		}
	}


	void OnTriggerExit (Collider other) {
		if(other.gameObject == player) {
			playerInRange = false;
		}
	}


	void Update (){
		timer += Time.deltaTime;

		if(timer >= timeBetweenAttacks && playerInRange && enemyHealth.currentHealth > 0) {
			Attack ();
		}
			
		if(playerHealth.currentHealth <= 0) {
			navMesh.enabled = false;
			moveScript.enabled = false;
		}
	}


	void Attack () {
		timer = 0f;

		if(playerHealth.currentHealth > 0) {
			playerHealth.TakeDamage (attackDamage);
		}
	}
}
