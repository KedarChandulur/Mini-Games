using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Attacker : MonoBehaviour {

	private float movementSpeed;

	private Transform playerBase;

	private Vector3 directionToMove;


	void Start () {
		playerBase = GameObject.FindGameObjectWithTag ("Player").transform;
		directionToMove = (playerBase.localPosition - transform.localPosition).normalized;

	
		movementSpeed = Random.Range (0f, 6f);
	}
	

	void Update () {
		transform.Translate (directionToMove * movementSpeed * Time.deltaTime);

		transform.localScale = Vector3.one * Mathf.Sin (Time.time) * 1.5f;

		if (Vector3.Distance (transform.localPosition, playerBase.localPosition) < 0.1f) {
			Spawner.IsGamePlaying = false;
			Time.timeScale = 0f;
		}
	}

	private void OnMouseDown() {
		GameObject.Destroy (this.gameObject);
	}
}
