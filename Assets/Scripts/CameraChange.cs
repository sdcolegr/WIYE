using UnityEngine;
using System.Collections;
public class CameraChange : MonoBehaviour {

	Ray ray;
	RaycastHit hit;

	public GameObject listener;
	public GameObject mainCamera;
	public GameObject computerCamera;
	public GameObject computerScreen;
	//public GameObject textBox;
	public LayerMask mask;

	void Update(){
		ray = (((computerCamera.active == true) ? computerCamera : mainCamera).GetComponent<Camera>()).ScreenPointToRay(Input.mousePosition);
		if (Input.GetMouseButtonDown (0)) {
			if (Physics.Raycast (ray, out hit, Mathf.Infinity, mask)) {
				if (hit.collider.gameObject == this.gameObject && computerCamera.active == false) {
					//computerScreen.SetActive (true);
					Cursor.lockState = CursorLockMode.None;
					computerCamera.SetActive(true);
					mainCamera.SetActive(false);
				} 
			}
			else if (computerCamera.active == true) {
				//computerScreen.SetActive (false);
				mainCamera.SetActive(true);
				computerCamera.SetActive(false);
				Cursor.lockState = CursorLockMode.Locked;
				mainCamera.GetComponent<UnityStandardAssets.Utility.SimpleMouseRotator> ().centerCam ();
				Cursor.lockState = CursorLockMode.None;
			}
		}
	}
}