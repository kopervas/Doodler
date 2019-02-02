using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Score : MonoBehaviour {
	public Transform tr;
	public Transform camera1;
	public static string txt;
	public Text txt1;
    public static string message;
    //public GameObject panel;
    //public Text resultat;
    //public AnimatorUpdateMode aum = AnimatorUpdateMode.Normal;

	int x, max = 0,y;
	// Use this for initialization
	void Start () {
        txt1.text = "Score";
		txt1.enabled = true;
        //txt.enabled = true;
        //panel.SetActive(false);
    }

	// Update is called once per frame
	void FixedUpdate () {
		x = (int)tr.position.y;
		y = (int)camera1.position.y;
        txt1.text = x.ToString();

        if (Input.GetKeyUp(KeyCode.P))
        {
            Time.timeScale = 0f;
        }

        if (x < y - 8)
        {
            Debug.Log("Game menu");
            txt = txt1.text;
            SceneManager.LoadScene("Menu");
            message = txt1.text;
            //Time.timeScale = 0f;
            if (Input.GetKeyUp(KeyCode.Q))
            {
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
            else if (Input.GetKeyUp(KeyCode.E))
            {
                Application.Quit();
                Debug.Log("Game over");
            }
        }
            Debug.Log(y.ToString());
            if (max < x)
            {
                max = x;
                txt1.text = x.ToString();
                Debug.Log(x.ToString());
            }
        }
	}

