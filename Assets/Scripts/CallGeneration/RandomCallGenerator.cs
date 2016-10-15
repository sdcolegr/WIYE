using UnityEngine;
using System.Collections;

public class RandomCallGenerator : MonoBehaviour {

	public Call GenerateCall() {
		string callerName = GenerateName();
		float callLegitimacy = GenerateLegitimacy();
		Location callLocation = GenerateLocation();
		Call.CallType callType = GenerateCalltype(callLocation);
		int scale = GenerateScale();

		// set up those values

		Call newCall = new Call();
		newCall.Setup(callerName,callLegitimacy,callLocation,callType, scale);
		newCall.DebugPrint();
		return newCall;
	}

	private string GenerateName() {
		return "John Doe";
	}
	private float GenerateLegitimacy() {
		if (Random.value <= .2f)
			return 0.0f;
		else 
			return 1.0f;
	}
	private Location GenerateLocation() {
		//Grab a random location and return it
		int locNum = (int)Mathf.Floor(MapInformation.gameMapInfo.Locations.Length * Random.value);
		return MapInformation.gameMapInfo.Locations[locNum];
	}
	private Call.CallType GenerateCalltype(Location local) {
		// Calculate a call based on the Animation curves as probibilites.
		float total = local.crimeStats + local.fireStats + local.medicalStats;
		float rng = total * Random.value;
		if (rng <= local.crimeStats) 
			return Call.CallType.Crime;
		else if (rng <= local.crimeStats+local.fireStats)
			return Call.CallType.Fire;
		else 
			return Call.CallType.Medical;
	}

	// 5 levels of scale, 1 relativly minor/common, 5 the worst possible
	private int GenerateScale() {
		// .7, .15, .07, .05, .03
		float rng = Random.value;
		if (rng <= .7) return 1;
		else if (rng <= .85) return 2;
		else if (rng <= .92) return 3;
		else if (rng <= .97) return 4;
		else return 5;
	}
}
