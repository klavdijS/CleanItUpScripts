using UnityEngine;
using UnityEngine.UI;

public class BakterijaHealth : MonoBehaviour
{
	public int startingHealth = 100;           
	public int currentHealth;                   
	public int scoreValue = 10;                 
	public AudioClip deathClip;
	public ParticleSystem dead;		
	Vector3 up = new Vector3(0.5f,0,0);

	Animator anim;                             
	AudioSource enemyAudio;                     
	ParticleSystem hitParticles;                
	SphereCollider sphere;            
	bool isDead;
	EnemyMovement enemyMov;

	void Awake ()
	{
		anim = GetComponent <Animator> ();
		enemyAudio = GetComponent <AudioSource> ();
		sphere = GetComponent <SphereCollider> ();
		currentHealth = startingHealth;
		hitParticles = GetComponentInChildren<ParticleSystem> ();
		enemyMov = GetComponentInParent<EnemyMovement> ();
	}
		
	public void TakeDamage (int amount, Vector3 hitPoint)
	{
		if(isDead)
			return;

		// Play the hurt sound effect.
		enemyAudio.Play ();

		currentHealth -= amount;

		// Set the position of the particle system to where the hit was sustained.
		hitParticles.transform.position = hitPoint;

	
		hitParticles.Play();

		if(currentHealth <= 0)
		{
			Death ();
		}
	}
		
	void Death ()
	{
		
		isDead = true;
		//enemyMov.enabled = false;

		enemyAudio.clip = deathClip;
		enemyAudio.Play ();

		KillTextSetter.killCount--;

		sphere.isTrigger = true;

		Instantiate(dead,transform.position+up,transform.rotation);

		Destroy(gameObject,enemyAudio.clip.length);


	}
		
}