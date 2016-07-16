using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class ParticleTrigger : MonoBehaviour {

	ParticleSystem particle;
	public GameObject part;
	ParticleSystem newPart;
	public Text health;
	float timer;
	float speed;
	float changeSpeed;
	AudioSource deathAudio;


	public GameObject gameOver;
	Animator anim;
	scrip script;
	void Start () {
		
		health.text = LifeCarrier.life.ToString ();
		deathAudio = this.GetComponent<AudioSource> ();
		particle = part.GetComponent<ParticleSystem> ();
		anim = this.GetComponent<Animator> ();
		script = this.GetComponent<scrip> ();
		speed = script.speed;
		changeSpeed = script.speed - 3;
	}

	void OnTriggerStay(Collider other){
		if (other.name == "Luza") {
			timer += Time.deltaTime;
			transform.GetComponent<scrip> ().speed = changeSpeed;
			newPart = (ParticleSystem)Instantiate (particle, transform.position, Quaternion.identity);
			newPart.Play ();
			if (timer >= 1.5) {
				LifeCarrier.life -= 3;
				timer = 0;
			}
			health.text = ""+LifeCarrier.life;
			if (LifeCarrier.life <= 0) {
				health.text = "0";
				GameOver ();
			}
			Destroy (newPart, 1f);
		}
	}

	void OnTriggerExit(Collider other){
		transform.GetComponent<scrip> ().speed = speed;
	}

	public void GameOver(){
		//deathAudio.clip = deathClip;
		deathAudio.Play ();
		anim.SetBool ("IsDead", true);
		script.enabled = false;
		Invoke ("SetBG", 8f);
	}

	void SetBG(){
		gameOver.SetActive (true);
	}

}
