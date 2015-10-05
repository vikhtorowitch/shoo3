using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class getFinTime : MonoBehaviour {

	Text pText;
	private float ftime;

	void Start () {
		pText = GetComponent<Text>();
		getPointsFromPrefs ();
	}

	// Update is called once per frame
	void Update () {
		//getPointsFromPrefs ();
	}

	void getPointsFromPrefs() {
		ftime = GlobalPrefs.Instance.getPoints ();

		pText.text = ftime.ToString();
	}
}
