﻿using UnityEngine;
using System.Collections;

public class ChangeScreenTerminal : MonoBehaviour {

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
		map.SetActive(false);
		info.SetActive(false);
		terminal.SetActive(true);
		mapSelect.SetActive(false);
		infoSelect.SetActive(false);
		terminalSelect.SetActive(false);
		exit.SetActive(true);
	}
}