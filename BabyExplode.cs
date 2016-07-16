using UnityEngine;
using System.Collections;

public class BabyExplode : MonoBehaviour {

   
    public Transform explosionPrefab;
    // Update is called once per frame
	ParticleSystem playParticle;
	GameObject player;
	PlayerLife health;

	void Start(){
		playParticle = GetComponentInChildren<ParticleSystem> ();
		player = GameObject.FindGameObjectWithTag ("Player");
		health = player.GetComponent<PlayerLife> ();
	}

    void OnCollisionEnter(Collision collision)
    {
		if (collision.gameObject.tag == "Player") {
			ContactPoint contact = collision.contacts [0];
			Quaternion rot = Quaternion.FromToRotation (Vector3.up, contact.normal);
			Vector3 pos = contact.point;
			playParticle.Play ();
			Destroy (gameObject);
			health.TakeDamage (10);
		}
          
        
    }
 }

