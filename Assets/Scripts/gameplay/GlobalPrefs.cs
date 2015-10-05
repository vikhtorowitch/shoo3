using UnityEngine;
using System.Collections;

public class GlobalPrefs : MonoBehaviour
{
	public static GlobalPrefs Instance { get; private set; }

	private int points;
	private int health;
	private int lives;

	private float gameTime;

	void Start() {
		Instance = this;
		points = 0;
		health = 100;
		lives = 3;
	}

	public void makeDamage(int _hits) {
		health -= _hits;
		if (health <= 0) {
			lives -= 1;
			if (lives <= 0) {
				gameTime = Time.timeSinceLevelLoad;
				Application.LoadLevel("funnish");
			} else {
				health = 100;
				Application.LoadLevel("mainScene");
			}
		}
	}

	public void Reset() {
		points = 0;
		health = 100;
		lives = 3;
	}

	public int getHealth() {
		return health;
	}

	public void addPoints(int _points) {
		points += _points;	
	}

	public int getPoints() {
		return points;
	}

	public int getLives() {
		return lives;
	}

	public float getTime() {
		return gameTime;
	}

}