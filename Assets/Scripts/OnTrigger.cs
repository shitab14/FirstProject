using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnTrigger : MonoBehaviour {

	public Material material;
	public Renderer rend;
	public Material original_material;

	bool uprising=false;

	public float amount = 50f;
	Rigidbody rigidbody;
	Vector3 pos;

	void Start(){
		rigidbody=GetComponent<Rigidbody>();

		pos = this.transform.position;
	}

	void Update(){
		if (uprising) {
			
			pos.y += 2f * Time.deltaTime;
			//Debug.Log (Time.deltaTime);
			transform.position = pos;

			if (pos.y > 8) {
				uprising = false;
				transform.position = pos;
			}
		} 
		
	}

	void OnTriggerEnter(Collider c){
		Debug.Log ("Touch");
		rend.sharedMaterial=material;
	}
	void OnTriggerStay(Collider c){
		rend.sharedMaterial=material;
	}
	void OnTriggerExit(Collider c){
		rend.sharedMaterial = material;//original_material;

		//rigidbody.useGravity=false;




		uprising = true;


		float h = Input.GetAxis ("Horizontal") * amount * Time.deltaTime;
		float v = Input.GetAxis ("Vertical") * amount * Time.deltaTime;

		rigidbody.AddTorque (transform.up * h);
		rigidbody.AddTorque (transform.right * v);
	}
}
