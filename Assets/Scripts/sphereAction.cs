using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class sphereAction : MonoBehaviour {

	public Rigidbody rigidbody;
	void Start(){
		rigidbody=GetComponent<Rigidbody>();
	}
	public void OnMouseDown(){
		rigidbody.AddForce (transform.forward * 1000, ForceMode.Acceleration);
		rigidbody.useGravity = true;

		/* Vector3 pos = this.transform.position;

		pos.x += 10f * Time.deltaTime;
		pos.z += 10f * Time.deltaTime;
		transform.position = pos;
		*/
		//transform.Translate (pos.x+20f*Time.deltaTime, 0, pos.z+20f*Time.deltaTime);

	}
}
