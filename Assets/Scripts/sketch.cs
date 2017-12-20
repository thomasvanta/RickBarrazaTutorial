using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sketch : MonoBehaviour {

	public GameObject _prefab;

	public int totalCubes = 6;

	public float maxSize = 0.5f;

	public float minSize = 0.1f;

	public float maxSpeed = 1.0f;

	public Vector3 positionOffset = Vector3.zero;

	public float totalDistance = 3.0f;

	// Use this for initialization
	void Start () {

		for (int i = 0; i < totalCubes; i++) {

			float percent = i / (float)totalCubes;

			float sin = Mathf.Sin (percent * Mathf.PI/2);

			float x = positionOffset.x;
			float y = positionOffset.y;
			float z = positionOffset.z + (sin * totalDistance);

			var newPrefab = (GameObject)Instantiate (_prefab, new Vector3(x, y, z), Quaternion.identity);
			newPrefab.GetComponent<cubeController> ().setSize (maxSize * (1.0f - percent) + minSize);
			newPrefab.GetComponent<cubeController> ().rotateSpeed = maxSpeed * (1.0f - percent);//Random.value;
		}
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
