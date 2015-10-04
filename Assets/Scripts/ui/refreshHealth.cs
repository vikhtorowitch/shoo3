using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class refreshHealth : MonoBehaviour {

	Text pText;
	private int health;

	// Use this for initialization
	void Start () {
		pText = GetComponent<Text>();
		getHealthFromPrefs ();
	}
	
	// Update is called once per frame
	void Update () {
		getHealthFromPrefs ();
	}
	void getHealthFromPrefs() {
		health = GlobalPrefs.Instance.getHealth ();
		pText.text = health.ToString();
	}
}
