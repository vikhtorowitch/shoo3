using UnityEngine;
using System.Collections;

public class btnRestartClick : MonoBehaviour {

	public void OnClick(){
		GlobalPrefs.Instance.Reset ();
		Application.LoadLevel("mainScene");
	}
}
