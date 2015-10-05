using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class refreshLives : MonoBehaviour {

	Text pText;
	private int lives;

	// Use this for initialization
	void Start () {
		pText = GetComponent<Text>();
		getLivesFromPrefs ();
	}
	
	// Update is called once per frame
	void Update () {
		getLivesFromPrefs ();
	}
	void getLivesFromPrefs() {
		lives = GlobalPrefs.Instance.getLives ();
		pText.text = lives.ToString();
	}
}
