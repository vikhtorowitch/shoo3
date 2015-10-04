using UnityEngine;
using System.Collections;

public class enemyMoving : MonoBehaviour {

	public float move_speed;
	public float rotation_speed;

	private bool attack;
	private float timer;

	GameObject playerObject;

	Transform player;
	Transform enemy;


	void Awake() {
		playerObject = GameObject.FindGameObjectWithTag ("Player");
		player = playerObject.GetComponent<Transform> ();
		enemy = GetComponent<Transform> ();

		attack = false;
		timer = 0f;
	}

	void Update() {
		timer += Time.deltaTime;

		var look_dir = player.position - enemy.position;
		look_dir.y = 0;
		enemy.rotation = Quaternion.Slerp(enemy.rotation,Quaternion.LookRotation(look_dir),rotation_speed*Time.deltaTime);
		enemy.position += enemy.forward * move_speed * Time.deltaTime;

		if (attack && (timer>=1f)) {
			timer = 0f;
			GlobalPrefs.Instance.makeDamage(10);
		}
	}

	void OnTriggerEnter (Collider other) {
		if (other.tag == "Player") {
			attack = true;

		}
	}
	void OnTriggerExit (Collider other) {
		if (other.tag == "Player") {
			attack = false;

		}
	}

}
