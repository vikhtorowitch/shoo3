using UnityEngine;
using System.Collections;

public class GlobalPrefs
{
	public static GlobalPrefs Instance { get; private set; }

	private int points;
	private int health;

	public void Awake()	{
		Instance = this;
		points = 0;
	}

	public void makeDamage(int _hits) {
		health -= _hits;
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

}