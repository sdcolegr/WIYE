using UnityEngine;
using System.Collections;

public class MapButton : MonoBehaviour {

	public GameObject popupMenu;
	public void OnMouseDown() {
		popupMenu.transform.position = this.transform.position;
	}
}
