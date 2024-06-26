using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour {

	[SerializeField]
	public struct Spawn {
		public int numberOfEnemies;
		public float timeBetweenSpawns;
	}

	public Spawn [] spawnInfo;

	private Spawn currentSpawn;

	void Start () {
		
	}
	

	void Update () {
		
	}
}
	
