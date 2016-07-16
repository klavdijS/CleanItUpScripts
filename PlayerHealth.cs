using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class PlayerHealth : MonoBehaviour {
	                 
	public int currentHealth;                             
	public Text healthText;                                                           
	public AudioClip deathClip;                                
	public GameObject gameOver;

	Animator anim;                                            
	AudioSource playerAudio;                                    
	PlayerMovement playerMovement;                              
	PlayerShooting playerShooting;                             
	bool isDead;                                             
	bool damaged;                                             


	void Awake (){
		anim = GetComponent <Animator> ();
		playerAudio = GetComponent <AudioSource> ();
		playerMovement = GetComponent <PlayerMovement> ();
		playerShooting = GetComponentInChildren <PlayerShooting> ();
		currentHealth = LifeCarrier.life;
		healthText.text = currentHealth.ToString ();
	}


	void Update (){
		if (LifeCarrier.life <= 0) {
			healthText.text = "0";
		}
	}


	public void TakeDamage (int amount)
	{

		damaged = true;

		LifeCarrier.life -= amount;

		currentHealth -= amount;

		healthText.text = currentHealth.ToString();

		playerAudio.Play ();

		if(currentHealth <= 0 && !isDead)
		{
			Death ();
		}
	}


	void Death ()
	{
		isDead = true;


		anim.SetBool ("IsDead", isDead);
		Invoke ("SetBG", 8f);

		playerAudio.clip = deathClip;
		playerAudio.Play ();

		playerMovement.enabled = false;
		playerShooting.enabled = false;
	}  

	void SetBG(){
		gameOver.SetActive (true);
	}
}
