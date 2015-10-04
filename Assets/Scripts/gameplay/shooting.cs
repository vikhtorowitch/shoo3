using UnityEngine;
using System.Collections;

public class shooting : MonoBehaviour {

	public Transform bullet;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (Input.GetMouseButtonDown (0)) {
			Transform BulletInstance = (Transform) Instantiate(bullet, GameObject.Find("weapon").transform.position, Quaternion.identity);
			BulletInstance.GetComponent<Rigidbody>().AddForce(transform.forward * 2000);

			// ;;
		}
	}
}
