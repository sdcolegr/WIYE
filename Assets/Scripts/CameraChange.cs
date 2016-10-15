using UnityEngine;
using System.Collections;
public class CameraChange : MonoBehaviour {
	
	public Camera cam1;
	public Camera cam2;

	void Start () {
		cam1.enabled = true;
		cam2.enabled = false;
	}
	void OnMouseDown() {
		cam1.enabled = !cam1.enabled;
		cam2.enabled = !cam2.enabled;
	}
}