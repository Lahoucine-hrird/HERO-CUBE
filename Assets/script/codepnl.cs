using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class codepnl : MonoBehaviour {

	// Use this for initialization
	public Text t;
	public Image textbox;
	public GameObject panelcode;
	public void num0(){
		t.text += "0";
	}
	public void num1(){
		t.text += "1";
	}
	public void num2(){
		t.text += "2";
	}
	public void num3(){
		t.text += "3";
	}
	public void num4(){
		t.text += "4";
	}
	public void num5(){
		t.text += "5";
	}
	public void num6(){
		t.text += "6";
	}
	public void num7(){
		t.text += "7";
	}
	public void num8(){
		t.text += "8";
	}
	public void num9(){
		t.text += "9";

	}
	public void exit(){
		panelcode.SetActive(false);
		Time.timeScale = 1f;
	}

	// Update is called once per frame

	void OnTriggerEnter2D(Collider2D cld)
	{

		if (cld.tag == "Player") {

			Time.timeScale = 0f;
			panelcode.SetActive(true);

		}
	}
	public GameObject gm;
	Animator an;
	public Image cd;
	 bool tv;
	public string code;
	public void but(){
		if (tv) {
			an.SetBool ("but", true);
			panelcode.SetActive (false);
			Time.timeScale = 1f;

		} else {
			t.text = "";
		}
	}
	void Start () {
		panelcode.SetActive(false);
		tv = false;
		an = gm.GetComponent<Animator> ();
	}
	void Update () {
		if (t.text.Length == 5 ) {
			t.text = "";

		}

		if (t.text == code) {
			tv = true;
			cd.GetComponent<Image> ().color=Color.green;
		}
	}
}
