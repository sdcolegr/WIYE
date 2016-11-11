using UnityEngine;
using System.Collections;

public class ChangeScreenExit : MonoBehaviour {
	
	public GameObject desktop;
	public GameObject map;
	public GameObject info;
	public GameObject terminal;
	public GameObject mapSelect;
	public GameObject infoSelect;
	public GameObject terminalSelect;
	public GameObject exit;
	
	void OnMouseDown() {
		desktop.SetActive(true);
		map.SetActive(false);
		info.SetActive(false);
		terminal.SetActive(false);
		mapSelect.SetActive(true);
		infoSelect.SetActive(true);
		terminalSelect.SetActive(true);
		exit.SetActive(false);
	}
}