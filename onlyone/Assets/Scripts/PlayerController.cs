using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {

	public KeyCode oneButton;
	public GameObject projectile;
	public int projectileSpeed;

	private Transform transform;

	// Start is called before the first frame update
	void Start() {
		transform = GetComponent<Transform>();
	}

	// Update is called once per frame
	void Update() {
		Shoot();
	}

	private void Shoot() {
		if (Input.GetKeyDown(oneButton)){
			Debug.Log("Shooooot");
			GameObject projectileInstance = Instantiate(projectile);
			projectileInstance.GetComponent<Transform>().position = transform.position;
			projectileInstance.GetComponent<Rigidbody2D>().velocity = new Vector2(0, 25);
			Destroy(projectileInstance, 3);
		}
	}
}
