using UnityEngine;
using System.Collections;

public class codeMessage : MonoBehaviour {
	string alphabet = "abcdefghijklmnopqrstuvwxyz";

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
	
	}
	/*
	public void displayCodeMessage(string message, GameObject displayGo, GameObject letterBoxPrefab ) {
		for (int x = 0; x < message.Length; x++){
			char c = message[x];

			GameObject lb = GameObject.Instantiate(letterBoxPrefab);

			lb.name = x;


		}
	}
*/

	public void selectInputField(GameObject letterBox) {
		UnityEngine.UI.InputField inputText = letterBox.GetComponent<UnityEngine.UI.InputField> ();
		inputText.ActivateInputField ();

	}

	public bool isAlphaChar(string inputChar) {
		if (alphabet.IndexOf(inputChar.ToLower()) > -1) {
				return true;
			} else {
				return false;
			}

	}

	public bool isNewLineChar(string inputChar) {
		if (inputChar == System.Environment.NewLine || inputChar == "\n") {
			return true;
		}


		return false;
	}
}
