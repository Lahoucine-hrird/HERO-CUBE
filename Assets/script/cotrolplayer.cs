using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;
using EZCameraShake;


public class cotrolplayer : MonoBehaviour {

	public float speed;
	private Rigidbody2D rb;
	private float movevinput;
	public float exjump;
	public ParticleSystem ps;



	private bool isgrandd;
	public Transform chekgend;
	public float checkraduis;

	public LayerMask whatisgrad;
	public AudioSource ad;
	private Animator an;


	public Scene s;

	// Use this for initialization
	void Start () {
		key = false;
		 s= SceneManager.GetActiveScene();
		pwin.SetActive (false);
		nbkey = 0;
		mor = 5;
		position = new List<Vector3> ();
		tt = 0;
		Time.timeScale = 1;
		vrds = false;
		t = 0;
		rb = GetComponent<Rigidbody2D>();
		an = GetComponent<Animator> ();
		Rgmspeed = gmspeed.GetComponent<SpriteRenderer> ();
		gamepnal.SetActive (false);
			
	}



	GameObject coin;



	// Update is called once per frame


	public GameObject gmspeed;
	SpriteRenderer Rgmspeed;

	public GameObject distroyanim;
	public GameObject distroyanim2;
	public AudioSource ds;
	public AudioSource ds2;
	public bool vrds;
	bool tch=false;
	public bool mort;
	public GameObject pwin;
	public int nbkey;
	public bool key;
	void OnTriggerEnter2D(Collider2D cld)
	{

		if (cld.tag == "key") {
			nbkey++;
			key = true;
		}
		if (cld.tag=="rec" ) {
			
			tch = true;
		}
		if (cld.tag=="win" ) {
			
			PlayerPrefs.SetInt("level",s.buildIndex-1);
			pwin.SetActive (true);
		}

			if (cld.tag == "enmy") {
			
			mor--;
			vrds = true;
			ds.Play ();
			CameraShaker.Instance.ShakeOnce (4f,2f,0.1f,1f);
			Dectroyme ();
			if (mort) {
				Dectroyme ();

			}
			israwning = true;			
			}
		if (cld.tag == "enmy2") {
			
			mor--;
			vrds = true;
			ds2.Play ();
			CameraShaker.Instance.ShakeOnce (2f, 2f, 0.1f, 1f);
			Instantiate (distroyanim, transform.position, Quaternion.identity);
			if (mort) {
				



				//Vector3 v = new Vector3 (transform.position.x, transform.position.y + 2.5f, transform.position.z);
				//Instantiate (distroyanim2, v, Quaternion.identity);
				gameObject.GetComponent<SpriteRenderer> ().enabled = false;

			}
			israwning = true;
		}

			if (cld.tag == "enmy3") {
			
			mor--;
			vrds = true;
			ds2.Play ();

			CameraShaker.Instance.ShakeOnce (2f, 2f, 0.1f, 1f);
			Vector3 v = new Vector3 (transform.position.x, transform.position.y + 1.3f, transform.position.z);
			Instantiate (distroyanim2, v, Quaternion.identity);
			if (mort) {
					
					

					
					
					gameObject.GetComponent<SpriteRenderer> ().enabled = false;
					
				}
			israwning = true;
			}


	}
	//destros
	public GameObject destro;

	public ParticleSystem speeeed;
	public ParticleSystem jmpprt;
	public List<Rigidbody2D> ply;
	public  bool vr;
	float tt;


	void FixedUpdate () {
		if (israwning && !mort) {
			rewind ();

		}
			
		else 
			record ();
		if(vr){

			Dectroyme ();
			if (tt == 0f) {
				CameraShaker.Instance.ShakeOnce (4f,4f,0.1f,1f);
				//Dectroyme ();
				ds.Play ();
				mor--;
				vr = false;
			}
			vrds = true;
			tt += Time.deltaTime;
			tt = 0;
		}
		isgrandd = Physics2D.OverlapCircle (chekgend.position, checkraduis, whatisgrad); 


		movevinput = Input.GetAxis ("Horizontal");
		if(jscontre.inputdir.x!=0)			
		movevinput = jscontre.inputdir.x;

		if (( Input.GetAxis ("Jump") > 0) && isgrandd) {
			
			rb.velocity = Vector2.up * exjump;
			if (!vrds) {
				
				ad.Play ();
			}
		
		}
		if (!isgrandd) {
			an.SetBool ("jump", true);
			jmpprt.Play();
		}else
			an.SetBool ("jump", false);

		if (movevinput > 0 || jscontre.inputdir.x>0) {
			jst.enabled = false;

			//gmspeed.SetActive (false);
			GetComponent<SpriteRenderer> ().flipX = true;
	
			gmspeed.GetComponent<SpriteRenderer> ().flipX = true;
				//	transform.localScale = new Vector3 (transform.localScale.x*-1,transform.localScale.y,transform.localScale.z);
			rb.velocity = new Vector2 (movevinput * speed, rb.velocity.y);
			an.SetBool ("run", true);
			an.SetBool ("idel", false);
			float i = 0.08f;

			jmpprt.Stop ();
			//Debug.Log (rb.velocity.x.ToString ());
			if (rb.velocity.x> 8) {
				speeeed.Play();
				//gmspeed.SetActive (true);

			}
			if (speed< 30) {
				speed += i;
				//gmspeed.SetActive (true);

			}




		} else if (movevinput < 0 || jscontre.inputdir.x<0) {
			jst.enabled = false;

			//gmspeed.SetActive (false);
			rb.velocity = new Vector2 (movevinput * speed, rb.velocity.y);
			GetComponent<SpriteRenderer> ().flipX = false;
			gmspeed.GetComponent<SpriteRenderer> ().flipX = false;
			an.SetBool ("run", true);
			an.SetBool ("idel", false);
			float i = 0.08f;
			//Debug.Log ("L:"+rb.velocity.x.ToString ());
			//transform.localScale = new Vector3 (transform.localScale.x*-1,transform.localScale.y,transform.localScale.z);

			if (rb.velocity.x <-8) {
				//gmspeed.SetActive (true);
				speeeed.Play();
			//	StartCoroutine ("showhimaya");

			}
			if (speed <30) {
				//gmspeed.SetActive (true);
				speed += i;
				//	StartCoroutine ("showhimaya");

			}

				



		} else if(jscontre.inputdir.x==0){
			jst.enabled = true;
			movevinput = 0;
			an.SetBool ("run", false);
			speeeed.Stop ();
			an.SetBool ("idel", true);
			speed = 4;
			//gmspeed.SetActive (false);
		}else{
			an.SetBool ("run", false);
			speeeed.Stop ();
			an.SetBool ("idel", true);
			speed = 4;
			//gmspeed.SetActive (false);
		}


		if(mor==0)
		{mort = true;}
		Debug.Log (mor.ToString ());

		if (vrds) {
			
			//Time.timeScale = 0.4f;

		/*	if (movevinput != 0 || Input.GetAxis ("Jump") > 0) {
				stopRwind ();

			}*/

			//startRwind ();
			
			//	stopRwind ();

					
				
			if (mort) {
				t += Time.deltaTime;
				gameObject.GetComponent<SpriteRenderer> ().enabled = false;
				startmenu.SetActive (false);
				speed = 0;
				exjump = 0;

				if( t > 1.2f)
				dest_roy ();
			}

		}

	}

	

	public int mor;
	public Image jst;
	float t;
	float mv = 0.4f;
	public void right(){
		mv = -1;
		rb.velocity = new Vector2 (mv * speed, rb.velocity.y);
		GetComponent<SpriteRenderer> ().flipX = false;
		gmspeed.GetComponent<SpriteRenderer> ().flipX = false;
		an.SetBool ("run", true);
		an.SetBool ("idel", false);
		float i = 0.05f;
		//Debug.Log ("L:"+rb.velocity.x.ToString ());
		//transform.localScale = new Vector3 (transform.localScale.x*-1,transform.localScale.y,transform.localScale.z);


			//gmspeed.SetActive (true);
			speeeed.Play();
			//	StartCoroutine ("showhimaya");


		speed += i;


		mv = mv + 1;
		speed = 6;
	}
	public void jmp(){
		if(isgrandd) {

			rb.velocity = Vector2.up * exjump;
			if (!vrds) {

				ad.Play ();
			}

		}
	}
	public void idel(){
		mv = 0;

		an.SetBool ("run", false);
		speeeed.Stop ();
		an.SetBool ("idel", true);
		speed = 6;
	}
	public void left(){
		//gmspeed.SetActive (false);
		mv=1;
		GetComponent<SpriteRenderer> ().flipX = true;

		gmspeed.GetComponent<SpriteRenderer> ().flipX = true;
		//	transform.localScale = new Vector3 (transform.localScale.x*-1,transform.localScale.y,transform.localScale.z);
		rb.velocity = new Vector2 (mv * speed, rb.velocity.y);
		an.SetBool ("run", true);
		an.SetBool ("idel", false);
		float i = 0.05f;

		jmpprt.Stop ();
		//Debug.Log (rb.velocity.x.ToString ());
	
			speeeed.Play();
			//gmspeed.SetActive (true);


		speed += i;
		mv = mv - 1;
		speed = 6;
	}

	public GameObject gamepnal;

	public GameObject startmenu;
	void dest_roy(){

		gamepnal.SetActive (true);
		Time.timeScale = 0f;
	}

	void Dectroyme(){
		
		destro.SetActive (true);

		for (int i = 0; i < ply.Count; i++) {
			ply [i].AddForceAtPosition ((ply[i].transform.position-transform.position)*Random.Range(800,1200),transform.position);
		}
	}
	List<Vector3> position;
	public bool israwning = false;
			
	void fixeupdate(){
		
			
	}
	void record(){
		
		position.Insert (0, transform.position);
		if (position.Count > Mathf.Round (5f / Time.fixedDeltaTime))
			position.RemoveAt (position.Count - 1);
		
		
			
	}
	void rewind(){
		if (position.Count > 0) {
			transform.position = position [0];
			position.RemoveAt (0);

		} else
			stopRwind ();
		GetComponent<Rigidbody2D>().AddForce (new Vector2(0,20));

		if (isgrandd) {
		if (movevinput != 0 || Input.GetAxis ("Jump") > 0) {
			
				for (int i = 0; i < position.Count; i++) {
				
					transform.position = position[i];
					position.RemoveAt (i);

				}
					
					

				}
					
				
			



		}

	}
	void startRwind(){
		


		israwning = true;
	}
	void stopRwind ()
	{
		
				israwning = false;
		

	}
}
