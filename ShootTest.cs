using UnityEngine;
using System.Collections;

public class ShootTest : MonoBehaviour {

	public Transform player;
	public float range = 10.0f;
	public float bulletImpulse= 40f;

	private bool onRange= false;
	float timer = 0;
	public Rigidbody projectile;
	AudioSource audio;

	void Start(){
		audio = GetComponent<AudioSource> ();

	}

	void Shoot(){

		if (LifeCarrier.life >= 0) {
			if (onRange) {

				Rigidbody bullet = (Rigidbody)Instantiate (projectile, transform.position + transform.forward, transform.rotation);
				bullet.AddForce (transform.forward * bulletImpulse, ForceMode.Force);
				audio.Play ();
				Destroy (bullet.gameObject, 1);
			}
		} else
			return;


	}

	void Update() {

		if (LifeCarrier.life > 0) {
			onRange = Vector3.Distance (transform.position, player.position) < range;

			if (onRange) {
				if (timer >= 0.5) {
					Shoot ();
					timer = 0;
				}
				transform.LookAt (player);
			}
		} else {
			return;
		}
		
		timer += Time.deltaTime;
	}


}
