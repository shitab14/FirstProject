using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cubeAction : MonoBehaviour {

	public float amount = 50f;

	public Rigidbody rigidbody;
	void Start(){
		rigidbody=GetComponent<Rigidbody>();
		Vector3 pos = this.transform.position;
		pos.y = pos.y + 8;
		transform.position = pos;
	}
	
	// Update is called once per frame
	void Update () {
		
	}


}
