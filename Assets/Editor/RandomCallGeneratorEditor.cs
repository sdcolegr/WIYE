using UnityEngine;
using UnityEditor;
using System.Collections;


[CustomEditor(typeof(RandomCallGenerator))]
public class RandomCallGeneratorEditor : Editor {
	public override void OnInspectorGUI() {
		RandomCallGenerator myScript = (RandomCallGenerator) target;
		if (GUILayout.Button("Generate Random Call")) {
			myScript.GenerateCall();
		}
	}
}
