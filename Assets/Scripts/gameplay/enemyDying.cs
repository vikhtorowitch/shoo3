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

		DestroyObject (this.gameObject, 0.2f);
		GlobalPrefs.Instance.addPoints (10);

		createEnemy (2);
	}

	private void createEnemy(int _count) {
		for (int i = 1; i<=_count; i++) {
			GameObject playerObject = GameObject.FindGameObjectWithTag ("Player");
			Transform player = playerObject.GetComponent<Transform> ();
			
			Vector3 rpos = player.position;
			rpos.y = 0.51f;
			rpos.x = -20 + rpos.x + Random.Range(5, 70);
			rpos.z = -20 + rpos.z + Random.Range(5, 70);
			Transform NewEnemyInstance = (Transform) Instantiate(spawnInstance, rpos, Quaternion.identity);

		}
	}
}
