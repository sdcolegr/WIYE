using UnityEngine;
using System.Collections;

public class ChangeScreenMap : MonoBehaviour {
	
	public GameObject desktop;
	public GameObject map;
	public GameObject info;
	public GameObject terminal;
	public GameObject mapSelect;
	public GameObject infoSelect;
	public GameObject terminalSelect;
	public GameObject exit;

	void OnMouseDown() {
		desktop.SetActive(false);
		map.SetActive(true);
		info.SetActive(false);
		terminal.SetActive(false);
		mapSelect.SetActive(false);
		infoSelect.SetActive(false);
		terminalSelect.SetActive(false);
		exit.SetActive(true);
	}
}
