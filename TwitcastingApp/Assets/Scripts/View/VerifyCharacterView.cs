using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class VerifyCharacterView : MonoBehaviour {

	public Text characterNameText;
	public Text characterFlavorText;
	public Image characterImage;

	// Use this for initialization
	void Start () {
		
	}

	public void SetView(string name, string flavor) {
		characterNameText.text = name;
		characterFlavorText.text = flavor;
	}
}
