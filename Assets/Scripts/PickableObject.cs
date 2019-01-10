using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickableObject : MonoBehaviour {

	public float distance = 15;
	public Rigidbody rigidbody;
	void OnMouseDrag(){
		//rigidbody=GetComponent<Rigidbody>();

		Vector3 mousePosition = new Vector3 (Input.mousePosition.x, Input.mousePosition.y, distance);
		Vector3 objPostion = Camera.main.ScreenToWorldPoint (mousePosition);

		transform.position = objPostion;

	}



}


