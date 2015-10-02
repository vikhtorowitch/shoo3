using UnityEngine;
using System.Collections;

public class enemyMoving : MonoBehaviour {

	public float move_speed;
	public float rotation_speed;
	GameObject playerObject;
	Transform player;
	Transform enemy;
	void Update()
	{
		playerObject = GameObject.FindGameObjectWithTag ("Player");
		player = playerObject.GetComponent<Transform> ();
		enemy = GetComponent<Transform> ();
		var look_dir = player.position - enemy.position;
		look_dir.y = 0;
		enemy.rotation = Quaternion.Slerp(enemy.rotation,Quaternion.LookRotation(look_dir),rotation_speed*Time.deltaTime);
		enemy.position += enemy.forward * move_speed * Time.deltaTime;
	}
}
