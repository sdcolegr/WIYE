using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class TextBoxManager : MonoBehaviour {

	Ray ray;
	RaycastHit hit;

	public GameObject camera;
	MonoBehaviour script;

	public GameObject listener;

	public GameObject textBox;
	public GameObject button;

	public Text theTextBox;
	public Text theButtonText;

	public TextAsset[] textFiles;
	public string[] textLines;

	public int currentLine;
	public int endAtLine;

	private int i;


	// Use this for initialization
	void Start () {

		i = 0;

		script = camera.GetComponent<UnityStandardAssets.Utility.SimpleMouseRotator> ();
		script.enabled = false;

		if (textFiles[i] != null) {
			textLines = (textFiles[i].text.Split ('\n'));
		}

		if (endAtLine == 0) {
			endAtLine = textLines.Length - 1;
		}

		theTextBox.text = textLines [currentLine];
		theButtonText.text = textLines [currentLine + 1];

	}

	void Update(){
		ray = Camera.main.ScreenPointToRay (Input.mousePosition);
		if (Physics.Raycast (ray, out hit)) {
			if (hit.collider.gameObject == listener) {
				if (Input.GetMouseButtonDown (0)) {

					if (textFiles[i] != null) {
						textLines = (textFiles[i].text.Split ('\n'));
					}

					if (endAtLine == 0) {
						endAtLine = textLines.Length - 1;
					}

					theTextBox.text = textLines [currentLine];
					theButtonText.text = textLines [currentLine + 1];

					textBox.SetActive (true);
					button.SetActive (true);
					Screen.lockCursor = true;
					script.enabled = false;
					Screen.lockCursor = false;
				}
			}
		}
	}

	public void clicked() {
		currentLine += 2;
		if (currentLine > endAtLine) {
			textBox.SetActive (false);
			button.SetActive (false);
			Screen.lockCursor = true;
			script.enabled = true;
			Screen.lockCursor = false;
			i++;
			currentLine = 0;
			endAtLine = 0;
		}
		theTextBox.text = textLines [currentLine];
		theButtonText.text = textLines [currentLine + 1];
	}
		
}
