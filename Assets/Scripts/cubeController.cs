using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubeController : MonoBehaviour {

	public float rotateSpeed = 1.0f;
	public Vector3 spinSpeed = Vector3.zero;
	Vector3 spinAxis = Vector3.up;

	// Use this for initialization
	void Start () {
		spinSpeed = spinSpeed + new Vector3 (Random.value, Random.value, Random.value);
		spinAxis.x = Random.Range (-0.1f, 0.1f);
		
	}
	
	// Update is called once per frame
	void Update () {
		this.transform.Rotate (spinSpeed);
		this.transform.RotateAround (Vector3.zero, spinAxis, rotateSpeed);
		
	}

	public void setSize(float _size){
		this.transform.localScale = new Vector3 (_size, _size, _size);
	}
}
