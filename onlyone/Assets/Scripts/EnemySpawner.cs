using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour {

	//not currently using 
	enum EnemySpeeds {
		slow, normal, fast 
	}

	public int spawnTimer = 180;
	private int spawnCounter;

	public GameObject enemy;
	public int[] speeds = { 5, 10, 20 };

	//position
	public int lowerBound = -3;
	public int upperBound = 4;
	public int xPos = 5;

	// Start is called before the first frame update
	void Start() {
		this.spawnCounter = this.spawnTimer;
	}

	// Update is called once per frame
	void Update() {
		SpawnEnemy();
	}

	void SpawnEnemy() {
		spawnCounter--;
		if (spawnCounter <= 0) {
			float yPos = Random.value * (upperBound - lowerBound) + lowerBound;
			GameObject enemy = Instantiate(this.enemy, new Vector3(xPos, yPos, 0), Quaternion.identity);
			float speed = speeds[Random.Range(0, speeds.Length)];
			enemy.GetComponent<Rigidbody2D>().velocity = new Vector2(-speed, 0);
			Destroy(enemy, 6);
			this.spawnCounter = this.spawnTimer; 
		}
	}
}

