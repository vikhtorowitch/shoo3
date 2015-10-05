using UnityEngine;
using System.Collections;

public class funnishStart : MonoBehaviour {

	// Use this for initialization
	void Start () {

		CursorLockMode wantedMode;
		Cursor.lockState = wantedMode = CursorLockMode.None;
		Cursor.visible = true;

	}
	

}
