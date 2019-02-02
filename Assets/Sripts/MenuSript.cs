using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuSript : MonoBehaviour {
    public Text skills;
	// Use this for initialization
	void Start () {
        skills.text = SceneManager.GetSceneByName("SampleScene").ToString();
	}
	
	// Update is called once per frame
	void Update () {
        if (Input.GetKeyUp(KeyCode.Q))
        {
            SceneManager.LoadScene("SampleScene");
        }
        else if (Input.GetKeyUp(KeyCode.E))
        {
            Application.Quit();
            Debug.Log("Game over");
        }
    }
}
