using UnityEngine;
using System.Collections;
using UnityEngine.UI;

[RequireComponent (typeof(AudioSource))]

public class PlayLastVideo: MonoBehaviour {

	public MovieTexture movie;
	private AudioSource audio;
	float duration;

	// Use this for initialization

	public void Start () {
		GetComponent<RawImage> ().texture = movie as MovieTexture;
		audio = GetComponent<AudioSource> ();
		audio.clip = movie.audioClip;
		duration = movie.duration;
		Invoke ("loadMainMenu", duration + 2f);
		movie.Play ();
		audio.Play ();
	}
	void loadMainMenu(){
		Application.LoadLevel ("mainMenu");
	}
	// Update is called once per frame
	void Update () {

	}
}
