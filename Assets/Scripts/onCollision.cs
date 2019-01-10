using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class onCollision : MonoBehaviour {

	void OnCollisionEnter(Collision collision){
		Debug.Log ("Lagse mamma");
	}
	void OnCollisionStay(Collision collision){
		Debug.Log ("Lege ase mamma");
	}
	void OnCollisionExit(Collision collision){
		Debug.Log ("chole gese");
	}
}
