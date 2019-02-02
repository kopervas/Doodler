using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Profil : MonoBehaviour {
    public Text text_profil;
    //public InputField inputfield;

    // Use this for initialization
    void Start () {
        text_profil.text = My_text.MyText;

    }
	
	// Update is called once per frame
	public void LoadText() {
		
	}
}
