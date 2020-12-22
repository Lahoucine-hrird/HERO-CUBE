using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.EventSystems;

public class jscontre : MonoBehaviour,IDragHandler,IPointerDownHandler,IPointerUpHandler {

	// Use this for initialization
	public Image jscontner;
	public Image jspoid;
	public static Vector3 inputdir;
	void Start () {
		inputdir = Vector3.zero;
	}
	public  void OnDrag(PointerEventData pedData){
		Vector3 pedposition=Vector3.zero;
		RectTransformUtility.ScreenPointToWorldPointInRectangle (jscontner.rectTransform, pedData.position, null,out pedposition);

		pedposition.x = pedposition.x / jscontner.rectTransform.sizeDelta.x;
		pedposition.y = pedposition.y / jscontner.rectTransform.sizeDelta.y;

		float x;
		if (jscontner.rectTransform.pivot.x == 1) {
			x = pedposition.x * 2 + 1; 
		} else {
			x = pedposition.x * 2 - 1; 
		
		}
		float y;
		if (jscontner.rectTransform.pivot.y == 1) {
			y = pedposition.y * 2 + 1; 
		} else {
			y = pedposition.y * 2 - 1; 

		}


		inputdir = new Vector3 (x,y,0);
		if (inputdir.magnitude > 1) {
			inputdir.Normalize ();
		}
		jspoid.rectTransform.anchoredPosition = new Vector3 (inputdir.x * (jscontner.rectTransform.sizeDelta.x / 3), inputdir.y * (jscontner.rectTransform.sizeDelta.y / 3));
		
	}
	public  void OnPointerDown(PointerEventData pedData){
		OnDrag (pedData);

	
	}

	public  void OnPointerUp(PointerEventData pedData){
		inputdir = Vector3.zero;
		jspoid.rectTransform.anchoredPosition = Vector3.zero;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
