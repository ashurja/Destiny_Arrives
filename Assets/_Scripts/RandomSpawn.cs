// Jamshed Ashurov 
// 05/03/2018
// This code serves as the GameController script. It spwans the fucntions. 
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomSpawn : MonoBehaviour {

	public GameObject[] routeprefabs; 
	public GameObject player;

	private Transform playerTransform; 
	private float generateLength = 40.0f; 
	private float spawnZ = 0.0f;
	private int LastPrefabIndex = 0; 
	// Use this for initialization
	void Start () {
		playerTransform = GameObject.FindGameObjectWithTag ("Player").transform;
	}
	
	// Update is called once per frame
	void Update () {
	}

	public void SpawnTile(int prefabIndex = -1)
	{

		GameObject go; 
		go = Instantiate (routeprefabs [RandomPrefabIndex()], new Vector3 (0f, 0f, 0f), Quaternion.identity) as GameObject; 
		// Instantiates random prefabs. 

		//go.transform.position = new Vector3 (0f, 0f, 0f); //Vector3.left * spawnZ; 
		//spawnZ += generateLength; 

	}

	private int RandomPrefabIndex() 
	{
		if (routeprefabs.Length <= 1) 
			return 0; 

		int randomIndex = LastPrefabIndex; 
		while (randomIndex == LastPrefabIndex) {
			randomIndex = Random.Range (0, routeprefabs.Length); 
		}
		LastPrefabIndex = randomIndex; 
		return randomIndex; 

		// The lines of code above are used to randomly generate prefabs and make sure that the last used prefab is not used immideately after again.  
	}
}