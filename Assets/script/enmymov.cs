using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class enmymov : MonoBehaviour {


	 Transform player;
	bool trv;

	public AudioSource ds;

	public GameObject ennmy;
	void OnTriggerEnter2D(Collider2D cld)
	{

		if (cld.tag== "enmy") {
			//Instantiate (enm,transform.position,Quaternion.identity);
			//	gameObject.SetActive (false);
			transform.localScale = new Vector3 (transform.localScale.x,transform.localScale.y-2.5f,transform.localScale.z);
			DestroyObject (gameObject, 0.2f);
			an.SetBool ("trv", true);
			Instantiate(ennmy,transform.position,Quaternion.identity);
			ds.Play();
			speed = 0;
		}
		if (cld.tag== "enmmmmycuberoge") {
			//Instantiate (enm,transform.position,Quaternion.identity);
			//	gameObject.SetActive (false);
			Instantiate(ennmy,transform.position,Quaternion.identity);
			DestroyObject (gameObject, 0.2f);
			an.SetBool ("trv", true);

			ds.Play();

		}



	}
	Animator an;
	// Use this for initialization
	void Start () {
		player = GameObject.FindGameObjectWithTag ("Player").GetComponent<Transform> ();
		trv = false;
		an = GetComponent<Animator> ();
		timshot = starttimeshot;
	}
	public float speed=13f;
	public float stpds;
	public float rspds;


	private float timshot;
	public float starttimeshot;

	public GameObject proj;
	// Update is called once per frame
	void Update () {
		
		float t = Vector2.Distance (transform.position, player.position);
	
		if (t < 18) {
			if (t > stpds) {

				an.SetBool ("trv", true);

				transform.position = Vector2.MoveTowards (new Vector2 (transform.position.x, transform.position.y), new Vector2 (player.position.x, transform.position.y), speed * Time.deltaTime);



			} else if (t < stpds && t>rspds) {
				an.SetBool ("trv", false);
				transform.position = this.transform.position;
			}else if(t<rspds)
			{an.SetBool ("trv", true);
				transform.position = Vector2.MoveTowards (new Vector2 (transform.position.x, transform.position.y), new Vector2 (player.position.x, transform.position.y), -speed * Time.deltaTime);
			}
			if (GameObject.FindGameObjectWithTag ("Player").GetComponent<cotrolplayer> ().mort == false) {
				if (timshot <= 0) {
					Instantiate (proj, transform.position, Quaternion.identity);
					timshot = starttimeshot;
				} else {
					timshot -= Time.deltaTime;
				}
			}


		}





	}

}
