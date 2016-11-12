using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TextBoxManager : MonoBehaviour {

	public GameObject camera;
	MonoBehaviour script;

	public GameObject textBox;
	public GameObject button;

	public Text theTextBox;
	public Text theButtonText;

	public TextAsset textFile;
	public string[] textLines;

	public int currentLine;
	public int endAtLine;


	// Use this for initialization
	void Start () {

		script = camera.GetComponent<UnityStandardAssets.Utility.SimpleMouseRotator> ();
		script.enabled = false;

		if (textFile != null) {
			textLines = (textFile.text.Split ('\n'));
		}

		if (endAtLine == 0) {
			endAtLine = textLines.Length - 1;
		}

	}

	void OnEnable () {
//		script.enabled = false;
	}

	void Update(){
		theTextBox.text = textLines [currentLine];
		theButtonText.text = textLines [currentLine + 1];
	}

	public void clicked() {
		currentLine += 2;
		if (currentLine > endAtLine) {
			textBox.SetActive (false);
			button.SetActive (false);
		}
	}

	void OnDisable() {
		Screen.lockCursor = true;
		script.enabled = true;
		Screen.lockCursor = false;
	}
}
