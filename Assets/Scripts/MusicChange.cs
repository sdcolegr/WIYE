using UnityEngine;
using System.Collections;

public class MusicChange : MonoBehaviour {
	
	public AudioSource song1;
	
	void Start() {
		song1.enabled = false;
	}
	
	void OnMouseDown() {
		song1.enabled = !song1.enabled;
	}
}