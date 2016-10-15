using UnityEngine;
using System.Collections;

public class Call  {
	//These three are just simple versions, these should be updated to contain more depth
	public enum CallType {Fire=0,Crime,Medical};

	private string name = "DefaultCall";
	private float legitimacy = .75f;
	private Location location = new Location();
	private CallType callType = (CallType)0;
	private int scale = 1; // This has different meanings in different contexts

	/*	Call is setup with getters and setters because I assume there is likly to be many interactions with the call script, 
	*	and I want to avoid things getting overwritten accidently
	*/
	public void Setup(string name, float legitimacy, Location location, CallType callType, int scale) {
		this.name = name;
		this.legitimacy = legitimacy;
		this.location = location;
		this.callType = callType;
		this.scale = scale;
	}

	public string getName() {
		return name;
	}

	public float getLegitimacy() {
		return legitimacy;
	}

	public Location getLocation() {
		return location;
	}

	public CallType getCallType() {
		return callType;
	}

	public int getScale() {
		return scale;
	}

	public void DebugPrint() {
		Debug.Log("Name:\t" + name + "\n" + 
			"Location:\t" + location.name + "\n" + 
			"CallType:\t" + callType + "\n" + 
			"Legit.:\t" + legitimacy + "\n" + 
			"Scale:\t" + scale + "\n");
	}
}
