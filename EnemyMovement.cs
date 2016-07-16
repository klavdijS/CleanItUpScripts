using UnityEngine;
using System.Collections;

public class EnemyMovement : MonoBehaviour
{
	public Transform player;              
	PlayerHealth playerHealth;     
	BakterijaHealth enemyHealth;        
	NavMeshAgent nav;
	Vector3 up = new Vector3(0,0.5f,0);

	void Awake ()
	{
		// Set up the references.
		player = GameObject.FindGameObjectWithTag ("Player").transform;
		playerHealth = player.GetComponent <PlayerHealth> ();
		enemyHealth = GetComponentInChildren <BakterijaHealth> ();
		nav = GetComponent <NavMeshAgent> ();
	}


	void Update ()
	{

		transform.position = transform.position + up;
		// If the enemy and the player have health left..
		if(enemyHealth.currentHealth > 0 && playerHealth.currentHealth > 0)
		{
			// ... set the destination of the nav mesh agent to the player.
			nav.SetDestination (player.position);
		}
		// Otherwise...
		else
		{
			// ... disable the nav mesh agent.
			nav.enabled = false;
		}
	} 
}