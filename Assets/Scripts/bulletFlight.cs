using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class bulletFlight : MonoBehaviour {

	public Transform enemy;
	GameObject player;


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

		//Text txt = GameObject.Find ("infoPoints");
		
		//txt.text = "tst";
		// определение игрока как объект при срабатывании триггера 
		if(other.gameObject.CompareTag("Enemy"))
		{
			DestroyObject(other.gameObject, 0.5f);



			Vector3 rpos = GetComponent<Transform>().position;
			rpos.y = 0.51f;
			rpos.x = -20 + rpos.x + Random.Range(5, 40);
			rpos.z = -20 + rpos.z + Random.Range(5, 40);
			Transform EnemyInstance = (Transform) Instantiate(enemy, rpos, Quaternion.identity);

		}
	}

}
