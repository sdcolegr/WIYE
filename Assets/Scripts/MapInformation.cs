using UnityEngine;
using System.Collections;

public class MapInformation : MonoBehaviour {
	public static MapInformation gameMapInfo = null;
	public string cityName;
	public Location[] Locations = new Location[] {};

	void Start() {
		//Set this mapinfo to the static variable, so we can access it from other scripts easily
		if (gameMapInfo == null)
			gameMapInfo = this;
		else
			Debug.LogError("We have multiple MapInfos in this scene!");
	}
}
