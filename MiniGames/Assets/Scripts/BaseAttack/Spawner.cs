using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class Spawner : MonoBehaviour {

	[SerializeField] private GameObject attackerPrefab;

	private float horizontalExtent;
	private float verticalExtent;

	public static bool IsGamePlaying;

	void Awake () {
		verticalExtent = Camera.main.orthographicSize;
		horizontalExtent = Camera.main.aspect * verticalExtent;
		IsGamePlaying = true;

		StartCoroutine (SpawnAttacker ()); 
	}
	


	IEnumerator SpawnAttacker() {
		float randomX = 0.0f;
		float randomY = 0.0f;
		while (IsGamePlaying) {
			randomX = Random.Range (-horizontalExtent, horizontalExtent);
			randomY = Random.Range (0, 10);

			if (randomY > 5f) {
				randomY = verticalExtent;
			} else {
				randomY = -verticalExtent;
			}

			GameObject attacker = Instantiate (attackerPrefab, new Vector3(randomX, randomY, 0f), Quaternion.identity);

			yield return new WaitForSeconds (1.3f);
		}
	}

}
