using UnityEngine;
using System.Collections;
public class CameraChange : MonoBehaviour {

	Ray ray;
	RaycastHit hit;
	
	public Camera cam1;
	public Camera cam2;
	public GameObject listener;
	public GameObject mainCamera;
	public GameObject computerScreen;
	public GameObject textBox;


	void Start () {
		cam1.enabled = true;
		cam2.enabled = false;
		//Screen.lockCursor = true;
	}
	void Update(){
		ray = Camera.main.ScreenPointToRay (Input.mousePosition);
		if (Physics.Raycast (ray, out hit)) {
			if (hit.collider.gameObject == listener) {
				if (Input.GetMouseButtonDown (0)) {
					computerScreen.SetActive (true);
					Screen.lockCursor = false;
					cam1.enabled = false;
					cam2.enabled = true;
				}
			} else if (hit.collider.gameObject != listener && cam2.enabled == true) {
				if (Input.GetMouseButtonDown (0)) {
					computerScreen.SetActive (false);
					cam1.enabled = true;
					cam2.enabled = false;
					Screen.lockCursor = true;
					mainCamera.GetComponent<UnityStandardAssets.Utility.SimpleMouseRotator> ().centerCam ();
					Screen.lockCursor = false;
				}
			}
		}
	}
}