using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {

	public float panSpeed= 20f;
	public float panBorderThickness=10f;


	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		Vector3 pos = transform.position;
		if ((Input.GetKey ("w")|| Input.mousePosition.y >=Screen.height-panBorderThickness) && pos.y<10){    // up
			pos.y += panSpeed * Time.deltaTime;
		}
		if ((Input.GetKey ("s")|| Input.mousePosition.y <=panBorderThickness)&& pos.y>2) {      //down
			pos.y -= panSpeed * Time.deltaTime;

		}
		if (Input.GetKey ("d")|| Input.mousePosition.x >=Screen.width+panBorderThickness) {					//right
			pos.z -= panSpeed * Time.deltaTime;
			}
		if (Input.GetKey ("a")|| Input.mousePosition.x <=panBorderThickness) {								//left
			pos.z += panSpeed * Time.deltaTime;

		}
		if (Input.GetKey ("e")) {	//backward
			pos.x -= panSpeed * Time.deltaTime;
		}

		if (Input.GetKey ("q") ) {	//forward
			
			pos.x += panSpeed * Time.deltaTime;

		}

			


		//transform.position = pos;
	}

	public void goback(){
		Vector3 pos = transform.position;
		pos.x -= panSpeed * Time.deltaTime;
		transform.position = pos;

	}

	public void goforward(){
		Vector3 pos = transform.position;
		pos.x += panSpeed * Time.deltaTime;
		transform.position = pos;
	}

}
