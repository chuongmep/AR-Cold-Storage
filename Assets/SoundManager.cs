using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    // Start is called before the first frame update
	public AudioSource source;
	bool isPlaying = false;


	public void switchState(){
		Debug.Log ("Switch state called");
	
		if (isPlaying) {
			source.Stop ();
			isPlaying = false;
		} else {
			source.Play ();
			isPlaying = true;
		}
			

	}
}
