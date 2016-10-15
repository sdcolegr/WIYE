using UnityEngine;
using System.Collections;


//Serializable tag allows all of these to show up in the editor, lets modifying arrays in editor work.
[System.Serializable]
public class Location : System.Object {
	public string name = "Unamed Zone";
	public float crimeStats = 0.2f;
	public float fireStats = 0.3f;
	public float medicalStats = 0.5f;


	//Ignore this if you want to
	/*
	//[Range(0.0f,1.0f)]
	[SerializeField]
	public float crimeStats{
		get{
			return _crimeStats;
		}
		set{
			float inValue = Mathf.Clamp(value,0.0f,1.0f);
			float difference = _crimeStats - inValue;
			float halfDiff = difference/2.0f;
			_crimeStats = inValue;
			_fireStats += halfDiff;
			_medicalStats += halfDiff; 
			validate();
		}
	}
	//[Range(0.0f,1.0f)]
	public float fireStats{
		get{
			return _fireStats;
		}
		set{
			float inValue = Mathf.Clamp(value,0.0f,1.0f);
			float difference = _fireStats - inValue;
			float halfDiff = difference/2.0f;
			_fireStats = inValue;
			_crimeStats += halfDiff;
			_medicalStats += halfDiff; 
			validate();
		}
	}
	//[Range(0.0f,1.0f)]
	public float medicalStats{
		get{
			return _medicalStats;
		}
		set{
			float inValue = Mathf.Clamp(value,0.0f,1.0f);
			float difference = _medicalStats - inValue;
			float halfDiff = difference/2.0f;
			_medicalStats = inValue;
			_fireStats += halfDiff;
			_crimeStats += halfDiff; 
			validate();
		}
	}

	private void validate() {
		// Makre sure the probablities sum to 1.0f
		while (crimeStats + fireStats + medicalStats != 1.0f) {
			float loss = 1.0f - (crimeStats + fireStats + medicalStats);
			Debug.Log("Expereince a slider loss of " + loss);
			medicalStats += loss;
		}
	}*/
}
