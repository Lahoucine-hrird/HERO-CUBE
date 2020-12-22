using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class cour : MonoBehaviour {

	// Use this for initialization
	public int health;
	public int numofhears;

	public Image[] hearts;
	public Sprite fullhear;
	public Sprite emptyheart;


	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		health=GetComponent<cotrolplayer> ().mor;
		if (health > numofhears) {
			health = numofhears;
		}
		for (int i = 0; i < hearts.Length; i++) {
			if (i < health) {
				hearts [i].sprite = fullhear;
			}else
				hearts [i].sprite = emptyheart;

			if (i < numofhears) {
				hearts [i].enabled = true;
			}else
				hearts [i].enabled = false;

		}
	}
}
