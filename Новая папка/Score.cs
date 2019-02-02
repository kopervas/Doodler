using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Score : MonoBehaviour {
	public Transform tr;
	public Transform camera1;
	public Text txt;
	public Text txt1;
	int x, max = 0,y;
	// Use this for initialization
	void Start () {
		txt1.enabled = false;
	}

	// Update is called once per frame
	void FixedUpdate () {
		x = (int)tr.position.y;
		y = (int)camera1.position.y;

		if (x <  y - 6) {
			txt1.enabled = true;
			if (Input.GetKeyUp (KeyCode.Q))
				SceneManager.LoadScene (SceneManager.GetActiveScene ().name);
			else if (Input.GetKeyUp (KeyCode.T)) {
				Application.Quit ();
				Debug.Log ("vnjfbvl");
			}
			//Time.timeScale = 0f;
		}
		//Debug.Log(y.ToString());
		if (max < x) {
			max = x;
			txt.text = x.ToString ();
			//Debug.Log(x.ToString());
		}
	}
}
