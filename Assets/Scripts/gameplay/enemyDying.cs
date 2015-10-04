using UnityEngine;
using System.Collections;

public class enemyDying : MonoBehaviour {

	public Transform spawnInstance;

	public bool isDead = false;

	void Awake(){
		isDead = false;
	}

	public void DieMazafaker(){
		isDead = true;

		GameObject playerObject = GameObject.FindGameObjectWithTag ("Player");
		Transform player = playerObject.GetComponent<Transform> ();

		Vector3 rpos = player.position;
		rpos.y = 0.51f;
		rpos.x = -20 + rpos.x + Random.Range(5, 40);
		rpos.z = -20 + rpos.z + Random.Range(5, 40);
		Transform NewEnemyInstance = (Transform) Instantiate(spawnInstance, rpos, Quaternion.identity);

		DestroyObject (this.gameObject, 0.2f);
	}
}
