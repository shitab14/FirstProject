using System.Collections;
using System.Collections.Generic;
using UnityEngine.Events;
using UnityEngine.EventSystems;
using UnityEngine;

public class onLongClick : MonoBehaviour {
	public float holdTime=1f;
	public UnityEvent onLongPress = new UnityEvent ();
	public void onPointerDown(PointerEventData eventData){
		Invoke ("OnLongPress", holdTime);
	}

	public void OnPointerUp(PointerEventData eventData){
		CancelInvoke ("OnLongPress");
	}

	public void OnPointerExit(PointerEventData eventData){
		CancelInvoke ("OnLongPress");
	}

	public void OnLongPress(){
		onLongPress.Invoke ();
	}

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
