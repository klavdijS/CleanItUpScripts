using UnityEngine;
using System.Collections;
using UnityEngine.UI;

[RequireComponent (typeof(AudioSource))]

public class VideoPlay : MonoBehaviour {

	public MovieTexture movie;
	private AudioSource audio;
	float duration;
	GameObject player;
	public GameObject lastVideo;
	PlayLastVideo play;

	// Use this for initialization
	public void Start () {
		//play = lastVideo.GetComponent<PlayLastVideo> ();
		player = GameObject.FindGameObjectWithTag ("Player");
		player.SetActive (false);
		GetComponent<RawImage> ().texture = movie as MovieTexture;
		audio = GetComponent<AudioSource> ();
		audio.clip = movie.audioClip;
		duration = movie.duration;
		Invoke ("playLastVideo", duration + 1f);
		movie.Play ();
		audio.Play ();
	}

	void playLastVideo(){
		lastVideo.SetActive (true);
		movie.Stop ();
		audio.Stop ();
		play.Start ();
	}
	// Update is called once per frame
	void Update () {
	
	}
}
