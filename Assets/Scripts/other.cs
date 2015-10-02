using UnityEngine;
using System.Collections;

public class other : MonoBehaviour {

	// Use this for initialization
	void Start () {

		CursorLockMode wantedMode;
		Cursor.lockState = wantedMode = CursorLockMode.Locked;
		Cursor.visible = false;
	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
