using UnityEngine;

public class BossHealth : MonoBehaviour
{
	public int startingHealth = 500;            // The amount of health the enemy starts the game with.
    public static int currentHealth;                  // The current health the enemy has.
    public int scoreValue = 10;                 // The amount added to the player's score when the enemy dies.
                                                //public AudioClip deathClip;
    public ParticleSystem dead;
    Vector3 up = new Vector3(0, 1f, 0);


                                                //AudioSource enemyAudio;                     // Reference to the audio source.
    ParticleSystem hitParticles;                // Reference to the particle system that plays when the enemy is damaged.
	CapsuleCollider sphere;            // Reference to the capsule collider.
    bool isDead;                                // Whether the enemy is dead.
    bool isSinking;                             // Whether the enemy has started sinking through the floor.
	public GameObject canvas;
	VideoPlay video;
	BossShootWalk bossShoot;
	ShootTest shotTest;
	public AudioSource gameMusic;

    void Awake()
    {
		bossShoot = GetComponent<BossShootWalk> ();
		shotTest = GetComponent<ShootTest> ();
		video = canvas.GetComponent<VideoPlay> ();
        // Setting up the references.
        //enemyAudio = GetComponent <AudioSource> ();
        hitParticles = GetComponentInChildren<ParticleSystem>();
		sphere = GetComponent<CapsuleCollider>();
        // Setting the current health when the enemy first spawns.
        currentHealth = startingHealth;
	
    }

    void Update()
    {
		Debug.Log (currentHealth);
        // If the enemy should be sinking...
        if (currentHealth <= 0)
        {
            Death();
        }
    }


    public void TakeDamage(int amount, Vector3 hitPoint)
    {
        // If the enemy is dead...
        if (isDead)
            // ... no need to take damage so exit the function.
            return;

        // Play the hurt sound effect.
        //enemyAudio.Play ();

        // Reduce the current health by the amount of damage sustained.
        currentHealth -= amount;

        // Set the position of the particle system to where the hit was sustained.
        hitParticles.transform.position = hitPoint;

        // And play the particles.
        hitParticles.Play();

        // If the current health is less than or equal to zero...
        if (currentHealth <= 0)
        {
			Invoke ("DeathAnimaton", 2f);
            // ... the enemy is dead.
            Death();
        }
    }

    void Death()
    {
        // The enemy is dead.
        isDead = true;

        // Turn the collider into a trigger so shots can pass through it.
		bossShoot.enabled = false;
		shotTest.enabled = false;
		Invoke ("PlayAnimation", 3f);
		//canvas.SetActive (true);

        // Tell the animator that the enemy is dead.

        // Change the audio clip of the audio source to the death clip and play it (this will stop the hurt clip playing).
        //enemyAudio.clip = deathClip;
        //enemyAudio.Play ();
    }

	public void PlayAnimation(){
		gameMusic.Stop ();
		canvas.SetActive (true);
		video.Start ();
	}

}