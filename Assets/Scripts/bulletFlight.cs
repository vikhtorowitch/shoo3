using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class bulletFlight : MonoBehaviour {

	public Transform enemy;
	GameObject player;

	enemyDying enemydying;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 pos = GetComponent<Transform> ().transform.position;
		//pos.z -= 1f;
		//GetComponent<Transform> ().transform.position = pos;
		if(pos.y <= 0.1) DestroyObject(this.gameObject, 1f);

	}

	void OnTriggerEnter (Collider other)
	{

		enemydying = other.gameObject.GetComponent<enemyDying> ();
		if (enemydying != null) {
			if (!enemydying.isDead) enemydying.DieMazafaker();
		}

		/*
		if(other.gameObject.CompareTag("Enemy"))
		{
			DestroyObject(this.gameObject);

			DestroyObject(other.gameObject);


			Vector3 rpos = GetComponent<Transform>().position;
			rpos.y = 0.51f;
			rpos.x = -20 + rpos.x + Random.Range(5, 40);
			rpos.z = -20 + rpos.z + Random.Range(5, 40);
			Transform NewEnemyInstance = (Transform) Instantiate(enemy, rpos, Quaternion.identity);

		}
		*/
	}

}
