using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class getFinScore : MonoBehaviour {

	Text pText;
	private int points;

	void Start () {
		pText = GetComponent<Text>();
		getPointsFromPrefs ();
	}

	// Update is called once per frame
	void Update () {
		//getPointsFromPrefs ();
	}

	void getPointsFromPrefs() {
		points = GlobalPrefs.Instance.getPoints ();
		pText.text = points.ToString();
	}
}
