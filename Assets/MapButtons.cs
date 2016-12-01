using UnityEngine;
using System.Collections;

public class MapButtons : MonoBehaviour {


	public GameObject menu;
	public Camera cam;
	GameObject[] buttons;
	public GameObject won;
	public GameObject lost;

	private string lastClicked;

	void Start() {
		buttons = GameObject.FindGameObjectsWithTag("MapButton");
	}

	// Update is called once per frame
	void Update () {
		if (Input.GetButtonDown("Fire1")) {
			//Shoot a raycast at our buttons.
			RaycastHit hit;
			Ray ray = cam.ScreenPointToRay(Input.mousePosition);
			if (Physics.Raycast(ray, out hit, 100.0f)) {
				foreach (GameObject o  in buttons) {
					if (o == hit.collider.gameObject) {
						if (o.name == "Fire") {
							lost.SetActive(true);
						}
						else if (o.name == "Police") {
							if (lastClicked != "Library")
								lost.SetActive(true);
								//Lose
							lost.SetActive(true);
						}
						else if (o.name == "Medical") {
							lost.SetActive(true);
						}
						else {
							menu.transform.position = o.transform.position;
							lastClicked = o.name;
						}
					}
				}
			}
		}
	}
}
